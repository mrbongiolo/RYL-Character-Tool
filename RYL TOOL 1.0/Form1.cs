/*
 * Project Name: RYL Character Tool
 * Author: Ralf Schmitz Bongiolo
 * Date: 18 / 03 / 2008
 * Comments: This is the main form class, I have made a class for each playable class ingame.
 *           BTW, sorry for my english :)         
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RYL_TOOL
{
    public partial class Form1 : Form
    {
        //raca = nation, so it indicates what nation the user choosed.
        int lvl, raca, minSTR, minCON, minDEX, minINT, minWIS;
        RYLBASE[] vetorRYL = new RYLBASE[1];

        
        //Novo metodo que exibe os stats diretamente nas comboBoxes
        void adicionaStatsPro()
        {
            //primeiro verificar os valores maximos permitidos para cada atributo
            //e guardalos na variaveis temporarias do metodo.
            int maxStr = vetorRYL[0].maxSTR();
            int maxCon = vetorRYL[0].maxCON();
            int maxDex = vetorRYL[0].maxDEX();
            int maxInt = vetorRYL[0].maxINT();
            int maxWis = vetorRYL[0].maxWIS();

            //verificar os valores maximos atuais e guarda-los nas vars temporarias
            int atualMaxStr = comboSTR.Items.Count + minSTR - 1;
            int atualMaxCon = comboCON.Items.Count + minCON - 1;
            int atualMaxDex = comboDEX.Items.Count + minDEX - 1;
            int atualMaxInt = comboINT.Items.Count + minINT - 1;
            int atualMaxWis = comboWIS.Items.Count + minWIS - 1;

            //STR
            if (maxStr > atualMaxStr)
            {
                int i;
                for (i = (atualMaxStr + 1); i <= maxStr; i++)
                {
                    comboSTR.Items.Add(i);
                }
            }
            else if (maxStr < atualMaxStr)
            {
                int i;
                for (i = atualMaxStr; i > maxStr; i--)
                {
                    comboSTR.Items.Remove(i);
                }
            }
            else
            {
                //se for igual, nao ira fazer nada
            }

            //CON
            if (maxCon > atualMaxCon)
            {
                int i;
                for (i = (atualMaxCon + 1); i <= maxCon; i++)
                {
                    comboCON.Items.Add(i);
                }
            }
            else if (maxCon < atualMaxCon)
            {
                int i;
                for (i = atualMaxCon; i > maxCon; i--)
                {
                    comboCON.Items.Remove(i);
                }
            }
            else
            {
                //se for igual, nao ira fazer nada
            }

            //DEX
            if (maxDex > atualMaxDex)
            {
                int i;
                for (i = (atualMaxDex + 1); i <= maxDex; i++)
                {
                    comboDEX.Items.Add(i);
                }
            }
            else if (maxDex < atualMaxDex)
            {
                int i;
                for (i = atualMaxDex; i > maxDex; i--)
                {
                    comboDEX.Items.Remove(i);
                }
            }
            else
            {
                //se for igual, nao ira fazer nada
            }

            //INT
            if (maxInt > atualMaxInt)
            {
                int i;
                for (i = (atualMaxInt + 1); i <= maxInt; i++)
                {
                    comboINT.Items.Add(i);
                }
            }
            else if (maxInt < atualMaxInt)
            {
                int i;
                for (i = atualMaxInt; i > maxInt; i--)
                {
                    comboINT.Items.Remove(i);
                }
            }
            else
            {
                //se for igual, nao ira fazer nada
            }

            //WIS
            if (maxWis > atualMaxWis)
            {
                int i;
                for (i = (atualMaxWis + 1); i <= maxWis; i++)
                {
                    comboWIS.Items.Add(i);
                }
            }
            else if (maxWis < atualMaxWis)
            {
                int i;
                for (i = atualMaxWis; i > maxWis; i--)
                {
                    comboWIS.Items.Remove(i);
                }
            }
            else
            {
                //se for igual, nao ira fazer nada
            }
        }


        //metodo que joga os stats nas comboBoxes correspondentes
        //method that put the stats on the comboboxes
        void adicionaStats(int minStr, int minCon, int minDex, int minInt, int minWis)
        {
            comboSTR.Items.Clear();
            comboCON.Items.Clear();
            comboDEX.Items.Clear();
            comboINT.Items.Clear();
            comboWIS.Items.Clear();
            
            //STR
            int i = 0;
            for (i = minStr; i <= vetorRYL[0].maxSTR(); i++)
            {
                comboSTR.Items.Add(i);
            }
            //CON
            i = 0;
            for (i = minCon; i <= vetorRYL[0].maxCON(); i++)
            {
                comboCON.Items.Add(i);
            }
            //DEX
            i = 0;
            for (i = minDex; i <= vetorRYL[0].maxDEX(); i++)
            {
                comboDEX.Items.Add(i);
            }
            //INT
            i = 0;
            for (i = minInt; i <= vetorRYL[0].maxINT(); i++)
            {
                comboINT.Items.Add(i);
            }
            //WIS
            i = 0;
            for (i = minWis; i <= vetorRYL[0].maxWIS(); i++)
            {
                comboWIS.Items.Add(i);
            }

            //selecionar os primeiro valores, assim eles irao aparecer na tela
            comboSTR.SelectedIndex = 0;
            comboCON.SelectedIndex = 0;
            comboDEX.SelectedIndex = 0;
            comboINT.SelectedIndex = 0;
            comboWIS.SelectedIndex = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.comboRaca, "Select a Nation");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.comboClasse, "Select a Class");
            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.comboLvl, "Select a Level");
        }

        //COMBOBOX DE RAÇA
        private void comboRaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboRaca.SelectedIndex)
            {
                case 0:
                    {
                        raca = 1;

                        comboClasse.Items.Clear();

                        comboClasse.Items.Add("Life");
                        comboClasse.Items.Add("Rune");
                        comboClasse.Items.Add("Shadow");
                        comboClasse.Items.Add("Attacker");
                        comboClasse.Items.Add("Templar");
                        comboClasse.Items.Add("Gunner");

                        comboClasse.Focus();
                        break;
                    }
                case 1:
                    {
                        raca = 2;

                        comboClasse.Items.Clear();
                        
                        comboClasse.Items.Add("Warrior");
                        comboClasse.Items.Add("Defender");
                        comboClasse.Items.Add("Cleric");
                        comboClasse.Items.Add("Priest");
                        comboClasse.Items.Add("Enchanter");
                        comboClasse.Items.Add("Sorcerer");
                        comboClasse.Items.Add("Archer");
                        comboClasse.Items.Add("Assassin");

                        comboClasse.Focus();
                        break;
                    }
            }
        }

        //COMBOBOX DE CLASSE
        private void comboClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboLvl.Focus();
        }

        //BOTÃO OK
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                //MERKHADIA
                if (raca == 1)
                {
                    //LIFE
                    if (comboClasse.SelectedIndex == 0)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Life(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //RUNE
                    else if (comboClasse.SelectedIndex == 1)
                    {
                        this.Text = "Rune";
                        
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Rune(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //SHADOW
                    else if (comboClasse.SelectedIndex == 2)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Shadow(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //ATTACKER
                    else if (comboClasse.SelectedIndex == 3)
                    {                        
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Attacker(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //TEMPLAR
                    else if (comboClasse.SelectedIndex == 4)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Templar(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //GUNNER
                    else if (comboClasse.SelectedIndex == 5)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Gunner(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //MENSAGEM SE NENHUMA CLASSE FOR SELECIONADA
                    else
                    {
                        MessageBox.Show("Please Select a Class", "Class not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                //KARTEFANT
                else if (raca == 2)
                {
                    //WARRIOR
                    if (comboClasse.SelectedIndex == 0)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Warrior(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //DEFENDER
                    else if (comboClasse.SelectedIndex == 1)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Defender(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //CLERIC
                    else if (comboClasse.SelectedIndex == 2)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Cleric(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //PRIEST
                    else if (comboClasse.SelectedIndex == 3)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Priest(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //ENCHANTER
                    else if (comboClasse.SelectedIndex == 4)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Enchanter(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //SORCERER
                    else if (comboClasse.SelectedIndex == 5)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Sorcerer(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //ARCHER
                    else if (comboClasse.SelectedIndex == 6)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Archer(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //ASSASSIN
                    else if (comboClasse.SelectedIndex == 7)
                    {
                        lvl = Int32.Parse(comboLvl.Text);

                        vetorRYL[0] = new Assassin(lvl);

                        vetorRYL[0].calculaBonusPoints();
                        bPointsValue.Text = vetorRYL[0].ToString();

                        vetorRYL[0].calculaStats();

                        minSTR = vetorRYL[0].Str;
                        minCON = vetorRYL[0].Con;
                        minDEX = vetorRYL[0].Dex;
                        minINT = vetorRYL[0].Inte;
                        minWIS = vetorRYL[0].Wis;

                        //joga os stasts nos combos
                        this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
                    }
                    //MENSAGEM SE NENHUMA CLASSE FOR SELECIONADA
                    else
                    {
                        MessageBox.Show("Please Select a Class!", "Class not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                //MENSAGEM SE NENHUMA RAÇA FOR SELECIONADA
                else
                {
                    MessageBox.Show("Please Select a Nation!", "Nation not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //MENSAGEM SE O LEVEL NAO FOR ESPECIFICADO
            catch
            {
                MessageBox.Show("Please Select the Level!", "Level not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //COMBO DE STR
        private void comboSTR_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fixSTR;
            fixSTR = vetorRYL[0].Str;
            
            int newSTR;
            newSTR = Int32.Parse(comboSTR.Text);

            vetorRYL[0].Str = Int32.Parse(comboSTR.Text);

            vetorRYL[0].BonusPoints = vetorRYL[0].calcDiferencaBPointsSTR(newSTR, fixSTR);

            bPointsValue.Text = vetorRYL[0].ToString();


            this.adicionaStatsPro();


            //joga os stasts nos combos
            //this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
        }

        //COMBO DE CON
        private void comboCON_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fixCON;
            fixCON = vetorRYL[0].Con;

            int newCON;
            newCON = Int32.Parse(comboCON.Text);

            vetorRYL[0].Con = Int32.Parse(comboCON.Text);

            vetorRYL[0].BonusPoints = vetorRYL[0].calcDiferencaBPointsCON(newCON, fixCON);

            bPointsValue.Text = vetorRYL[0].ToString();


            this.adicionaStatsPro();


            //joga os stasts nos combos
            //this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
        }

        //COMBO DE DEX
        private void comboDEX_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fixDEX;
            fixDEX = vetorRYL[0].Dex;

            int newDEX;
            newDEX = Int32.Parse(comboDEX.Text);

            vetorRYL[0].Dex = Int32.Parse(comboDEX.Text);

            vetorRYL[0].BonusPoints = vetorRYL[0].calcDiferencaBPointsDEX(newDEX, fixDEX);

            bPointsValue.Text = vetorRYL[0].ToString();


            this.adicionaStatsPro();


            //joga os stasts nos combos
            //this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
        }

        //COMBO DE INT
        private void comboINT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fixINT;
            fixINT = vetorRYL[0].Inte;

            int newINT;
            newINT = Int32.Parse(comboINT.Text);

            vetorRYL[0].Inte = Int32.Parse(comboINT.Text);

            vetorRYL[0].BonusPoints = vetorRYL[0].calcDiferencaBPointsINT(newINT, fixINT);

            bPointsValue.Text = vetorRYL[0].ToString();


            this.adicionaStatsPro();


            //joga os stasts nos combos
            //this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
        }

        //COMBO DE WIS
        private void comboWIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fixWIS;
            fixWIS = vetorRYL[0].Wis;

            int newWIS;
            newWIS = Int32.Parse(comboWIS.Text);

            vetorRYL[0].Wis = Int32.Parse(comboWIS.Text);

            vetorRYL[0].BonusPoints = vetorRYL[0].calcDiferencaBPointsWIS(newWIS, fixWIS);

            bPointsValue.Text = vetorRYL[0].ToString();


            this.adicionaStatsPro();


            //joga os stasts nos combos
            //this.adicionaStats(minSTR, minCON, minDEX, minINT, minWIS);
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //CRIAR ABOUT BOX E EXIBIR
            AboutBox novaAboutBox = new AboutBox();
            novaAboutBox.Show();
        }

        private void skillTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRIAR FORM DE SKILLTABLE E EXIBIR
            FormSkillTable novaSkillTable = new FormSkillTable();
            novaSkillTable.Show();
        }
    }
}