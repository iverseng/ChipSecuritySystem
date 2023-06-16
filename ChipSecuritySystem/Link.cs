using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ChipSecuritySystem.Tree;

namespace ChipSecuritySystem
{
    internal class Link
    {
        public bool canLinkBasic(ColorChip[] chips)
        {

            Color startColor = Color.Blue;
            bool canLink = false;

            for (int i = 0; i < 2; i++)
            {
                foreach (ColorChip c in chips)
                {
                    if (c.StartColor.Equals(startColor))
                    {
                        startColor = c.EndColor;
                        Console.WriteLine(c);
                        i = 0;

                        if (c.EndColor.Equals(Color.Green))
                        {
                            canLink = true;
                        }
                    }
                }
            }
            if (canLink)
            {
                Console.WriteLine("It Can!");
                return true;
            }
            else
            {
                Console.WriteLine("It Can't :(");
                return true;
            }
        }
        public bool canLinkAdvanced(ColorChip[] chips)
        { 
            ColorChip parentChip = null;
            List<ColorChip> tempChips = new List<ColorChip>(chips);
            OneWayTree<ColorChip> tree = new OneWayTree<ColorChip>(null);
            Node<ColorChip> node1 = null;
            Node<ColorChip> node2 = null;
            Node<ColorChip> node3 = null;
            Node<ColorChip> node4 = null;
            Node<ColorChip> node5 = null;
            Node<ColorChip> node6 = null;
            bool canLink = false;

            foreach (ColorChip chip in tempChips)
            {
                if (chip.StartColor == Color.Blue)
                {
                    Console.WriteLine(chip);
                    node1 = new Node<ColorChip>(chip);
                    tree.Root.AddChild(node1);
                    parentChip = chip;
                    tempChips.Remove(chip);
                    break;
                }
            }
            if (parentChip != null)
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (ColorChip chip in tempChips)
                    {
                        if (parentChip.EndColor.Equals(chip.StartColor))
                        {
                            i = 0;
                            Console.WriteLine(chip);

                            if (node2 == null)
                            {
                                node2 = new Node<ColorChip>(chip);
                                node1.AddChild(node2);
                            }
                            else if(node3 == null)
                            {
                                if (parentChip.Equals(node1))
                                {
                                    node3 = new Node<ColorChip>(chip);
                                    node1.AddChild(node3);
                                }
                                if (parentChip.Equals(node2))
                                {
                                    node3 = new Node<ColorChip>(chip);
                                    node2.AddChild(node3);
                                }
                            }
                            else if(node4 == null)
                            {
                                if (parentChip.Equals(node1))
                                {
                                    node4 = new Node<ColorChip>(chip);
                                    node1.AddChild(node4);
                                }
                                if (parentChip.Equals(node2))
                                {
                                    node4 = new Node<ColorChip>(chip);
                                    node2.AddChild(node4);
                                }
                                if (parentChip.Equals(node3))
                                {
                                    node4 = new Node<ColorChip>(chip);
                                    node3.AddChild(node4);
                                }
                            }
                            else if(node5 == null)
                            {
                                if (parentChip.Equals(node1))
                                {
                                    node5 = new Node<ColorChip>(chip);
                                    node1.AddChild(node5);
                                }
                                if (parentChip.Equals(node2))
                                {
                                    node5 = new Node<ColorChip>(chip);
                                    node2.AddChild(node5); 
                                }
                                if (parentChip.Equals(node3))
                                {
                                    node5 = new Node<ColorChip>(chip);
                                    node3.AddChild(node5);
                                }
                                if (parentChip.Equals(node4))
                                {
                                    node5 = new Node<ColorChip>(chip);
                                    node4.AddChild(node5); 
                                }
                            }
                            else if(node6 == null)
                            {
                                if (parentChip.Equals(node1))
                                {
                                    node6 = new Node<ColorChip>(chip);
                                    node1.AddChild(node6);
                                }
                                if (parentChip.Equals(node2))
                                {
                                    node6 = new Node<ColorChip>(chip);
                                    node2.AddChild(node6); 
                                }
                                if (parentChip.Equals(node3))
                                {
                                    node6 = new Node<ColorChip>(chip);
                                    node3.AddChild(node6);
                                }
                                if (parentChip.Equals(node4))
                                {
                                    node6 = new Node<ColorChip>(chip);
                                    node4.AddChild(node6);
                                }
                                if (parentChip.Equals(node5))
                                {
                                    node6 = new Node<ColorChip>(chip);
                                    node5.AddChild(node6);
                                }
                            }
                            else
                            {
                                break;
                            }

                            if (chip.EndColor.Equals(Color.Green))
                            {
                                canLink = true;
                            }
                            tempChips.Remove(chip);
                            break;
                        }
                    }
                }
            }
            if (canLink)
            {
                Console.WriteLine("It Can!");
                return true;
            }
            else
            {
                Console.WriteLine("It Can't :(");
                return true;
            }
        }
    }
}
