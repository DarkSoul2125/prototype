using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class poorconfig:builder
    {
        private persona persona = new persona();

        public override void setweapon()
        {
            persona.weapon = "axe";
        }

        public override void setpictures()
        {
            persona.pictures = Image.FromFile("C:\\Users\\minAd\\Desktop\\constract\\builder\\WindowsFormsApp1\\poor.png");
        }

        public override void setarmor()
        {
            persona.armor = "bronze armor";
        }

        public override void setamulet()
        {
            persona.amulet = "amber";
        }

        public override void setring()
        {
            persona.ring = "ruby ring";
        }

        public override void setsubweapon()
        {
            persona.subweapon = "axe";
        }

        public override void setpotions()
        {
            persona.potions = "small health potions ";
            persona.potions += "small speed potions ";
            persona.potions += "small defense potions ";
        }

        public override persona build()
        {
            setweapon();
            setarmor();
            setamulet();
            setring();
            setsubweapon();
            setpictures();
            setpotions();
            return persona;
        }
    }
}
