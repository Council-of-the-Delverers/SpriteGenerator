using System;
using System.Collections.Generic;
using System.IO;

namespace SpriteGenerator
{
	class MainClass
	{
        [STAThread]
		public static void Main(string[] args)
		{
            using (ChoiceForm form = new ChoiceForm()) {
                form.ShowDialog();
            }
            DirectoryInfo inputDir = null;
            if (Directory.Exists("Input")) {
                inputDir = new DirectoryInfo(ChoiceForm.inputPath);
            }

            if (!Directory.Exists("Output")) {
                Directory.CreateDirectory("Output");
            }

            DirectoryInfo outputDir = new DirectoryInfo("Output");
            FileInfo paletteFile = new FileInfo("Input/colors.png");

            int padding = 3;
			int spritesWide = 12;
			int spritesHigh = 8;
			int spriteSize = 24;
			int width = (spritesWide * spriteSize) + padding * (spritesWide + 1);
			int height = (spritesHigh * spriteSize) + padding * (spritesHigh + 1);
			SpritesheetGen spriteSheet = new SpritesheetGen(width, height, padding);

			for (int i = 0; i < spritesHigh * spritesWide; i++)
			{
				var parts = getParts();
				var name = string.Format("dude_{0}.png", i);
				var sprite = SpriteGenerator.Generate(inputDir, parts, paletteFile);

				spriteSheet.AddSprite(sprite);
				sprite.Save(Path.Combine(outputDir.FullName, name));
			}

			spriteSheet.Save(Path.Combine(outputDir.FullName, "allSprites.png"));

			Console.WriteLine("All done! Sprites were written to");
			Console.WriteLine(outputDir.FullName);
		}

        static string[] getParts()
        {

            List<string[]> validParts = new List<string[]>();
            switch (ChoiceForm.choice)
            {
                case ChoiceForm.Choice.CHARACTER:
                    validParts.Add(new string[] { "feet", "torso", "head", "helmet", "weapon", "shield" });
                    validParts.Add(new string[] { "feet", "torso", "head", "helmet", "weapon" });
                    validParts.Add(new string[] { "feet", "torso", "head", "hair", "weapon" });
                    validParts.Add(new string[] { "feet", "torso", "head", "hair", "weapon", "shield" });

                    validParts.Add(new string[] { "feet", "torso", "head", "helmet" });
                    validParts.Add(new string[] { "feet", "torso", "head", "hair" });

                    validParts.Add(new string[] { "feet", "torso", "head", "helmet", "bow" });
                    validParts.Add(new string[] { "feet", "torso", "head", "hair", "bow" });
                    break;

                case ChoiceForm.Choice.SWORD:
                    validParts.Add(new string[] { "blade", "pommel", "grip", "crossguard" });
                    break;

                case ChoiceForm.Choice.HAMMER:
                    validParts.Add(new string[] { "head", "neck", "long_grip", "pommel" });
                    break;

                case ChoiceForm.Choice.ITEM:
                    break;

                case ChoiceForm.Choice.WAND:
                    break;
            }

            var rand = new Random();
            return validParts[rand.Next(validParts.Count)];
        }

    }
}
