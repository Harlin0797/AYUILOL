using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShaderEffectLibrary;

namespace LOLSkinGetter
{
    public class AyEffects
    {
        static HeiBai hb = new HeiBai();
        public static System.Windows.Media.Effects.Effect HeiBai()
        {
            return hb.FliterEffect(0,0);
        }
    }

    public class HeiBai : FliterTest
    {

        public override System.Windows.Media.Effects.Effect FliterEffect(double amount, double saturation)
        {
            byte bt = Convert.ToByte(235 + amount * 2);
            MonochromeEffect monochrome1 = new MonochromeEffect();
            monochrome1.FilterColor = System.Windows.Media.Color.FromRgb(bt, bt, bt);
            return monochrome1;
        }
    }

    public class FliterTest
    {
        private double amount = 0;
        private double saturation = 0;
        public virtual System.Windows.Media.Effects.Effect FliterEffect(double amount, double saturation)
        {
            return null;
        }



        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double Saturation
        {
            get { return saturation; }
            set { saturation = value; }
        }
    }
}
