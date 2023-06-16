using System;
using static ChipSecuritySystem.Tree;

namespace ChipSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorChip chip1 = new ColorChip(Color.Blue, Color.Yellow);
            ColorChip chip2 = new ColorChip(Color.Red, Color.Green);
            ColorChip chip3 = new ColorChip(Color.Yellow, Color.Red);
            ColorChip chip4 = new ColorChip(Color.Orange, Color.Purple);

            ColorChip[] chips = { chip1, chip2, chip3, chip4};
            Link link = new Link();
            bool canLink = link.canLinkBasic(chips);

            //ColorChip advancedChip1 = new ColorChip(Color.Blue, Color.Yellow);
            //ColorChip advancedChip2 = new ColorChip(Color.Orange, Color.Green);
            //ColorChip advancedChip3 = new ColorChip(Color.Yellow, Color.Red);
            //ColorChip advancedChip4 = new ColorChip(Color.Orange, Color.Purple);
            //ColorChip advancedChip5 = new ColorChip(Color.Yellow, Color.Orange);
            //ColorChip advancedChip6 = new ColorChip(Color.Purple, Color.Green);
            //ColorChip[] advancedChips = { advancedChip1, advancedChip2, advancedChip3, advancedChip4, advancedChip5, advancedChip6 };
            //bool canLinkAdvanced = link.canLinkAdvanced(advancedChips);
            //OneWayTree<ColorChip> tree = new OneWayTree<ColorChip>(chip1);
        }
    }
}
