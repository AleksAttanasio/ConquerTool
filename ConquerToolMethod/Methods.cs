﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConquerToolMethod
{
    public class Methods
    {
        public static int[,] ReadCommandList(string command)
        {
            int i = 0;
            int k = 0;
            int startIndex;
            int middleIndex;
            int endIndex;
            int firstLength;
            int secondLength;
            int x;
            int y;

            string[] singleCommand = command.Split('\n'); //divide every single command
            int[,] listOfCoord = new int[singleCommand.Length, 2];

            foreach (string cmd in singleCommand)
            {
                startIndex = cmd.IndexOf('(');
                middleIndex = cmd.IndexOf('|');
                endIndex = cmd.IndexOf(')');
                firstLength = middleIndex - startIndex; // x
                secondLength = endIndex - middleIndex; // y

                x = Convert.ToInt32(cmd.Substring(startIndex + 1, firstLength - 1));
                y = Convert.ToInt32(cmd.Substring(middleIndex + 1, secondLength - 1));

                listOfCoord[i, k] = x;
                k++;
                listOfCoord[i, k] = y;
                k = 0;
                i++;
            }

            return listOfCoord;
        }

        public static void SaveAttackList(List<Attack> attackList)
        {
            SortAscending(attackList);
            DateTime now = DateTime.Now;
            string fileName = "Lista_Attacchi" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" +
                                + DateTime.Now.Year + "__" + DateTime.Now.Hour + "." + DateTime.Now.Minute + "." +
                                + DateTime.Now.Second + ".txt";
            using (StreamWriter newLog = File.AppendText(fileName))
            {
                foreach(Attack attk in attackList)
                {
                    newLog.WriteLine("(" + attk.AttackType + ")");
                    newLog.WriteLine(attk.DestionationX + "|" + attk.DestinationY + " --> Partenza: " + attk.StartHour.Hour +
                                        ":" + attk.StartHour.Minute + ":" + attk.StartHour.Second + " il " + attk.StartHour.Day + 
                                        "/" + attk.StartHour.Month);
                    newLog.WriteLine();
                }
            }
        }

        public static void SaveAttackListAddress(List<Attack> attackList, string address)
        {
            SortAscending(attackList);
            DateTime now = DateTime.Now;
            string fileName = "Lista_Attacchi" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" +
                                +DateTime.Now.Year + "__" + DateTime.Now.Hour + "." + DateTime.Now.Minute + "." +
                                +DateTime.Now.Second + ".txt";

            string addressFile = address + @"\" + fileName;

            using (StreamWriter newLog = new StreamWriter(@addressFile, true))
            {
                foreach (Attack attk in attackList)
                {
                    newLog.WriteLine("(" + attk.AttackType + ")");
                    newLog.WriteLine(attk.DestionationX + "|" + attk.DestinationY + " --> Partenza: " + attk.StartHour.Hour +
                                        ":" + attk.StartHour.Minute + ":" + attk.StartHour.Second + " il " + attk.StartHour.Day +
                                        "/" + attk.StartHour.Month);
                    newLog.WriteLine();
                }
            }
        }

        public static List<Attack> SortAscending(List<Attack> list)
        {
            list.Sort((a, b) => a.StartHour.CompareTo(b.StartHour));
            return list;
        }
    }
}
