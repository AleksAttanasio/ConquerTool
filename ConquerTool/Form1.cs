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

                try
                {
                    Methods.SaveAttackListAddress(attackList, textPath.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Errore nel percorso. Controlla!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore di inserimento dati! Controlla le coordinate!");
            }

        }

        private void helpFake_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATTENZIONE!\n" +
                            "Il corretto inserimento dei dati prevede che non siano presenti righe vuote alla fine della lista," +
                            " prestate quindi attenzione che la barretta di inserimento testo si trovi alla destra dell'ultima" +
                            " parentesi e non sotto.\n È possibile inserire direttamente tutto l'ordine di attaco compresi del nome" +
                            " dei villaggi il programma è in grado di identificare le coordinate a patto che si trovino nel formato (x|y)." +
                            " Le parentesi e la barretta in mezzo sono necessarie.");
        }

        private void helpPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Il corretto inserimento dei percorso prevede un percorso fisso del tipo \"C:\\Users\" al quale dovrà essere aggiunto," +
                " se desiderato, il percorso della cartella dove si vuole salvare il piano.");
        }
    }
}
