using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConquerToolMethod;

namespace ConquerTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creato da JeremyReevo per i membri dell'ICDZ");
        }

        public void evaluateButton_Click(object sender, EventArgs e)
        {
            List<Attack> attackList = new List<Attack>();
            try
            {
                int[,] Fakelist = Methods.ReadCommandList(commandsText.Text);
                int[,] ConquerList = Methods.ReadCommandList(conquerList.Text);
                int k = 0;
                for (int i = 0; i < Fakelist.GetLength(0); i++)
                {
                    DateTime atDate = TimeEvaluation.GetArrivalTime(Convert.ToInt32(hoursText.Text), Convert.ToInt32(minutesText.Text),
                                                Convert.ToInt32(secondText.Text), Convert.ToInt32(xText.Text), Convert.ToInt32(yText.Text),
                                                Fakelist[i, k], Fakelist[i, k + 1], 0, 3);

                    Attack newAt = new Attack(Fakelist[i, k], Fakelist[i, k + 1], atDate, Attack.Type.FAKE);
                    if (!attackList.Contains(newAt))
                    {
                        attackList.Add(newAt);
                    }
                }
                for (int i = 0; i < ConquerList.GetLength(0); i++)
                {
                    DateTime atDate = TimeEvaluation.GetArrivalTime(Convert.ToInt32(hoursText.Text), Convert.ToInt32(minutesText.Text),
                                                Convert.ToInt32(secondText.Text), Convert.ToInt32(xText.Text), Convert.ToInt32(yText.Text),
                                                ConquerList[i, k], ConquerList[i, k + 1], 0, 3);

                    Attack newAt = new Attack(ConquerList[i, k], ConquerList[i, k + 1], atDate, Attack.Type.CONQUISTA);
                    if (!attackList.Contains(newAt))
                    {
                        attackList.Add(newAt);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Errore di inserimento dati! Controlla le coordinate!");
            }

        }

        private void saveTxtButton_Click(object sender, EventArgs e)
        {

            List<Attack> attackList = new List<Attack>();
            try
            {
                int[,] Fakelist = Methods.ReadCommandList(commandsText.Text);
                int[,] ConquerList = Methods.ReadCommandList(conquerList.Text);
                int k = 0;
                for (int i = 0; i < Fakelist.GetLength(0); i++)
                {
                    DateTime atDate = TimeEvaluation.GetArrivalTime(Convert.ToInt32(hoursText.Text), Convert.ToInt32(minutesText.Text),
                                                Convert.ToInt32(secondText.Text), Convert.ToInt32(xText.Text), Convert.ToInt32(yText.Text),
                                                Fakelist[i, k], Fakelist[i, k + 1], 0, 3);

                    Attack newAt = new Attack(Fakelist[i, k], Fakelist[i, k + 1], atDate, Attack.Type.FAKE);
                    if (!attackList.Contains(newAt))
                    {
                        attackList.Add(newAt);
                    }
                }
                for (int i = 0; i < ConquerList.GetLength(0); i++)
                {
                    DateTime atDate = TimeEvaluation.GetArrivalTime(Convert.ToInt32(hoursText.Text), Convert.ToInt32(minutesText.Text),
                                                Convert.ToInt32(secondText.Text), Convert.ToInt32(xText.Text), Convert.ToInt32(yText.Text),
                                                ConquerList[i, k], ConquerList[i, k + 1], 0, 3);

                    Attack newAt = new Attack(ConquerList[i, k], ConquerList[i, k + 1], atDate, Attack.Type.CONQUISTA);
                    if (!attackList.Contains(newAt))
                    {
                        attackList.Add(newAt);
                    }
                }

                Methods.SaveAttackList(attackList);
            }
            catch (Exception)
            {
                MessageBox.Show("Errore di inserimento dati! Controlla le coordinate!");
            }

        }
    }
}
