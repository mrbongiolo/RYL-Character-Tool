using System;
using System.Collections.Generic;
using System.Text;

namespace RYL_TOOL
{
    class Cleric:RYLBASE
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


        public Cleric()
            :base()
        {
        }
        
        public Cleric(int lv)
            :base(lv)
        {
        }


        public override int calcDiferencaBPointsSTR(int newStat, int fixStat)
        {
            return BonusPoints - (newStat - fixStat);
        }
        public override int calcDiferencaBPointsCON(int newStat, int fixStat)
        {
            return BonusPoints - ((newStat - fixStat) * 2);
        }
        public override int calcDiferencaBPointsDEX(int newStat, int fixStat)
        {
            return BonusPoints - (newStat - fixStat);
        }
        public override int calcDiferencaBPointsINT(int newStat, int fixStat)
        {
            return BonusPoints - (newStat - fixStat);
        }
        public override int calcDiferencaBPointsWIS(int newStat, int fixStat)
        {
            return BonusPoints - ((newStat - fixStat) * 2);
        }


        public override int maxSTR()
        {
            return Str + BonusPoints;
        }
        public override int maxCON()
        {
            return Con + (BonusPoints / 2);
        }
        public override int maxDEX()
        {
            return Dex + BonusPoints;
        }
        public override int maxINT()
        {
            return Inte + BonusPoints;
        }
        public override int maxWIS()
        {
            return Wis + (BonusPoints / 2);
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
            if (Lvl < 10)
            {
                return Con = Lvl - 1 + 20;
            }
            else
            {
                return Con = Lvl - 1 + 20;
            }
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
            return Dex = 20;
        }

        public override string exibeDex()
        {
            string composite = "" + Dex;
            return composite;
        }
        
        public override int calculaInt()
        {
            return Inte = 20;
        }

        public override string exibeInt()
        {
            string composite = "" + Inte;
            return composite;
        }

        public override int calculaWis()
        {
            if (Lvl < 10)
            {
                return Wis = 20;
            }
            else
            {
                return Wis = ((Lvl - 1) * 2) + 20;
            }
        }

        public override string exibeWis()
        {
            string composite = "" + Wis;
            return composite;
        }
    }
}
