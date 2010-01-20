using System;
using System.Collections.Generic;
using System.Text;

namespace RYL_TOOL
{
    class Enchanter:RYLBASE
    {
        private int str, con, dex, inte, wis;


        public override int Str
        {
            get { return str; }
            set { str = value; }
        }

        public override int Con
        {
            get { return con; }
            set { con = value; }
        }

        public override int Dex 
        {
            get { return dex; }
            set { dex = value; }
        }

        public override int Inte
        {
            get { return inte; }
            set { inte = value; }
        }

        public override int Wis
        {
            get { return wis; }
            set { wis = value; }
        }


        public Enchanter()
            :base()
        {
        }
        
        public Enchanter(int lv)
            :base(lv)
        {
        }


        public override int calcDiferencaBPointsSTR(int newStat, int fixStat)
        {
            return BonusPoints - (newStat - fixStat);
        }
        public override int calcDiferencaBPointsCON(int newStat, int fixStat)
        {
            return BonusPoints - (newStat - fixStat);
        }
        public override int calcDiferencaBPointsDEX(int newStat, int fixStat)
        {
            return BonusPoints - ((newStat - fixStat) * 2);
        }
        public override int calcDiferencaBPointsINT(int newStat, int fixStat)
        {
            return BonusPoints - ((newStat - fixStat) * 2);
        }
        public override int calcDiferencaBPointsWIS(int newStat, int fixStat)
        {
            return BonusPoints - (newStat - fixStat);
        }


        public override int maxSTR()
        {
            return Str + BonusPoints;
        }
        public override int maxCON()
        {
            return Con + BonusPoints;
        }
        public override int maxDEX()
        {
            return Dex + (BonusPoints / 2);
        }
        public override int maxINT()
        {
            return Inte + (BonusPoints / 2);
        }
        public override int maxWIS()
        {
            return Wis + BonusPoints;
        }


        public override void calculaStats()
        {
            calculaCon();
            calculaStr();
            calculaDex();
            calculaInt();
            calculaWis();
        }


        public override int calculaCon()
        {
            return Con = 20;
        }

        public override string exibeCon()
        {
            string composite = "" + Con;
            return composite;
        }

        public override int calculaStr()
        {
            return Str = 20;
        }

        public override string exibeStr()
        {
            string composite = "" + Str;
            return composite;
        }

        public override int calculaDex()
        {
            if (Lvl < 10)
            {
                return Dex = Lvl - 1 + 20;
            }
            else
            {
                int i = 1;
                Dex = 20;
                for (i = 1; i < Lvl; i++)
                {
                    if (i % 2 == 0)
                    {
                        Dex = Dex + 1;
                    }
                    if (i % 2 == 1)
                    {
                        Dex = Dex + 2;
                    }
                }
                return Dex;
            }
        }

        public override string exibeDex()
        {
            string composite = "" + Dex;
            return composite;
        }
        
        public override int calculaInt()
        {
            if (Lvl < 10)
            {
                return Inte = 20;
            }
            else
            {
                int i = 1;
                Inte = 20;
                for (i = 1; i < Lvl; i++)
                {
                    if (i % 2 == 0)
                    {
                        Inte = Inte + 2;
                    }
                    if (i % 2 == 1)
                    {
                        Inte = Inte + 1;
                    }
                }
                return Inte;
            }
        }

        public override string exibeInt()
        {
            string composite = "" + Inte;
            return composite;
        }

        public override int calculaWis()
        {
            return Wis = 20;
        }

        public override string exibeWis()
        {
            string composite = "" + Wis;
            return composite;
        }
    }
}
