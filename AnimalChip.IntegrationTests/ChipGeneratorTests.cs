using AnimalChip.ModelCRUDwithoutDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AnimalChip.IntegrationTests
{
    public class ChipGeneratorTests
    {
        [Fact]
        public void GenerateNumericChip_GeneratingSuccess_ReturnsInt()
        {
            var chip = ChipGenerator.generateNumericChip();

            Assert.NotEmpty(ChipGenerator.chips);
            Assert.InRange(chip, 100000, 100000000);
        }

        [Fact]
        public void GenerateTextChip_GeneratingLowerCase_ReturnsStringToLower()
        {
            var chip = ChipGenerator.generateTextChipChooseCase(true);

            Assert.NotEmpty(ChipGenerator.chips);
            Assert.InRange(chip.Length, 6, 8);
            Assert.Equal(chip.ToLower(), chip);
        }

        [Fact]
        public void GenerateTextChip_GeneratingUpperCase_ReturnsStringBigcase()
        {
            var chip = ChipGenerator.generateTextChipChooseCase(false);

            Assert.NotEmpty(ChipGenerator.chips);
            Assert.InRange(chip.Length, 6, 8);
            Assert.Equal(chip.ToUpper(), chip);
        }

        [Fact]
        public void GenerateMixedChip_GeneratingNumbersWithLowerCase_ReturnsCharsAndNumbersLowercase()
        {
            var chip = ChipGenerator.generateMixedCharsAndNumbers(true);

            Assert.NotEmpty(ChipGenerator.chips);
            Assert.InRange(chip.Length, 6, 8);
            Assert.StartsWith(chip.Substring(0, 6).ToLower(), chip);
        }

        [Fact]
        public void GenerateMixedChip_GeneratingNumbersWithUpperCase_ReturnsCharsAndNumbersUppercase()
        {
            var chip = ChipGenerator.generateMixedCharsAndNumbers(false);

            Assert.NotEmpty(ChipGenerator.chips);
            Assert.InRange(chip.Length, 6, 8);
            Assert.StartsWith(chip.Substring(0, 6).ToUpper(), chip);
        }
    }
}
