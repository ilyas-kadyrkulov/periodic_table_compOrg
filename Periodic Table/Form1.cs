using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periodic_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox159_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Boron";
            h.number = 5;
            h.oxidationState = "+3";
            h.sign = "B";
            h.yearDiscovered = 1808;         //ELEMENT info
            h.atomicMass = 10811;
            h.electronConf = "1s2 2s2 2p1";
            h.picAddress = @"https://image.made-in-china.com/43f34j00KarUkEiBRgpz/High-Quality-Boron-Carbide-Powder-B4c-with-Stable-Performance.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
;        }

        private void pictureBox236_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Hydrogen";
            h.number = 1;
            h.oxidationState = "+1";
            h.sign = "H";
            h.yearDiscovered = 1671;         //ELEMENT info
            h.atomicMass = 1;
            h.electronConf = "1s1";
            h.picAddress = @"https://www.rsc-cdn.org/www.rsc.org/periodic-table/content/Images/Elements/Hydrogen-L.jpg?6.2.65";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();


        }

        private void pictureBox235_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Lithium";
            h.number = 3;
            h.oxidationState = "+1";
            h.sign = "Li";
            h.yearDiscovered = 1817;
            h.atomicMass = 6.94;
            h.electronConf = "2s1";
            h.picAddress = @"https://thumbs.dreamstime.com/b/lithium-fine-isolated-white-background-149466820.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();


        }

        private void pictureBox229_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Beryllium";
            h.number = 4;
            h.oxidationState = "+2";
            h.sign = "Be";
            h.yearDiscovered = 1798;
            h.atomicMass = 9.012;
            h.electronConf = "2s2";
            h.picAddress = @"https://cdn.mos.cms.futurecdn.net/Botdck3S6sjWhQNTB28Uc3.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox234_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Sodium";
            h.number = 11;
            h.oxidationState = "+1";
            h.sign = "Na";
            h.yearDiscovered = 1807;
            h.atomicMass = 22.989;
            h.electronConf = "3s1";
            h.picAddress = @"https://zdraveplus.com/wp-content/uploads/2017/11/silicon-mineral-500x500.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }


        private void label1_MouseHover(object sender, EventArgs e)
        {
            pictureBox161.BorderStyle = BorderStyle.Fixed3D;
            pictureBox162.BorderStyle = BorderStyle.Fixed3D;
            pictureBox163.BorderStyle = BorderStyle.Fixed3D;
            pictureBox236.BorderStyle = BorderStyle.Fixed3D;
            pictureBox147.BorderStyle = BorderStyle.Fixed3D;
            pictureBox148.BorderStyle = BorderStyle.Fixed3D;
            pictureBox149.BorderStyle = BorderStyle.Fixed3D;
            pictureBox150.BorderStyle = BorderStyle.Fixed3D;
            pictureBox151.BorderStyle = BorderStyle.Fixed3D;
            pictureBox152.BorderStyle = BorderStyle.Fixed3D;
            pictureBox153.BorderStyle = BorderStyle.Fixed3D;
            pictureBox166.BorderStyle = BorderStyle.Fixed3D;
            pictureBox167.BorderStyle = BorderStyle.Fixed3D;
            pictureBox155.BorderStyle = BorderStyle.Fixed3D;
            pictureBox157.BorderStyle = BorderStyle.Fixed3D;
            pictureBox154.BorderStyle = BorderStyle.Fixed3D;
            pictureBox171.BorderStyle = BorderStyle.Fixed3D;       
            

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox161.BorderStyle = BorderStyle.None;
            pictureBox162.BorderStyle = BorderStyle.None;
            pictureBox163.BorderStyle = BorderStyle.None;
            pictureBox236.BorderStyle = BorderStyle.None;
            pictureBox147.BorderStyle = BorderStyle.None;
            pictureBox148.BorderStyle = BorderStyle.None;
            pictureBox149.BorderStyle = BorderStyle.None;
            pictureBox150.BorderStyle = BorderStyle.None;
            pictureBox151.BorderStyle = BorderStyle.None;
            pictureBox152.BorderStyle = BorderStyle.None;
            pictureBox153.BorderStyle = BorderStyle.None;
            pictureBox166.BorderStyle = BorderStyle.None;
            pictureBox167.BorderStyle = BorderStyle.None;
            pictureBox155.BorderStyle = BorderStyle.None;
            pictureBox157.BorderStyle = BorderStyle.None;
            pictureBox154.BorderStyle = BorderStyle.None;
            pictureBox171.BorderStyle = BorderStyle.None;
        }

        

        private void pictureBox228_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Magnesium";
            h.number = 12;
            h.oxidationState = "+2";
            h.sign = "Mg";
            h.yearDiscovered = 1808;         //ELEMENT info
            h.atomicMass = 24305;
            h.electronConf = "3s1";
            h.picAddress = @"https://www.seekpng.com/png/full/793-7932483_magnesium-element-magneziu-element.png";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox233_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Potassium";
            h.number = 19;
            h.oxidationState = "+1";
            h.sign = "K";
            h.yearDiscovered = 1807;         //ELEMENT info
            h.atomicMass = 39098;
            h.electronConf = "4s1";
            h.picAddress = @"https://i.online-almanac.com/preview/encyclopedia/4734415-potassium-element.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox227_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Calcium";
            h.number = 20;
            h.oxidationState = "+2";
            h.sign = "K";
            h.yearDiscovered = 1808;         //ELEMENT info
            h.atomicMass = 40078;
            h.electronConf = "4s2";
            h.picAddress = @"https://cdn.britannica.com/94/176094-050-40C6CB53/Calcite-calcium-carbonate-variety-crystals-development.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox223_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Scandium";
            h.number = 21;
            h.oxidationState = "+3";
            h.sign = "K";
            h.yearDiscovered = 1879;         //ELEMENT info
            h.atomicMass = 44955;
            h.electronConf = "4s2";
            h.picAddress = @"https://detaltorg.ru/site/userfiles/products/pokupaem_skandiy.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox219_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Titanium";
            h.number = 22;
            h.oxidationState = "+2, +3, +4";
            h.sign = "Ti";
            h.yearDiscovered = 1791;         //ELEMENT info
            h.atomicMass = 47867;
            h.electronConf = "3d2 4s2";
            h.picAddress = @"https://detaltorg.ru/site/userfiles/products/pokupaem_skandiy.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox215_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Vanadium";
            h.number = 23;
            h.oxidationState = "+2, +3, +4, +5";
            h.sign = "V";
            h.yearDiscovered = 1801;         //ELEMENT info
            h.atomicMass = 50942;
            h.electronConf = "3d3 4s2";
            h.picAddress = @"https://detaltorg.ru/site/userfiles/products/pokupaem_skandiy.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox211_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Chromium";
            h.number = 24;
            h.oxidationState = "+2, +3, +6";
            h.sign = "Cr";
            h.yearDiscovered = 1797;         //ELEMENT info
            h.atomicMass = 51996;
            h.electronConf = "3d5 4s1";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/thumb/a/a1/Chromium.jpg/220px-Chromium.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox207_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Manganese";
            h.number = 25;
            h.oxidationState = "+2, +3, +4, +5, +6, +7";
            h.sign = "Mn";
            h.yearDiscovered = 1774;         //ELEMENT info
            h.atomicMass = 54938;
            h.electronConf = "3d5 4s2";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Mangan_1-crop.jpg/200px-Mangan_1-crop.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox203_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Iron";
            h.number = 26;
            h.oxidationState = "+2, +3, +4, +6";
            h.sign = "Fe";
            h.yearDiscovered = -3500;         //ELEMENT info
            h.atomicMass = 55847;
            h.electronConf = "3d6 4s2";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/5/55/Iron_lamp.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox199_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Cobalt";
            h.number = 27;
            h.oxidationState = "+2, +3";
            h.sign = "Co";
            h.yearDiscovered = 1735;         //ELEMENT info
            h.atomicMass = 55933;
            h.electronConf = "3d7 4s2";
            h.picAddress = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcST-73tsuuKhxNUarkg6nYMdobtbE0jkyklNjQfD2HbSupfsROgSRKygVaD2Rq0L18UrJU&usqp=CAU";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox195_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Nickel";
            h.number = 28;
            h.oxidationState = "+2, +3";
            h.sign = "Ni";
            h.yearDiscovered = 1751;         //ELEMENT info
            h.atomicMass = 58690;
            h.electronConf = "3d8 4s2";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/5/57/Nickel_chunk.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox191_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Copper";
            h.number = 29;
            h.oxidationState = "+1, +2, +3";
            h.sign = "Cu";
            h.yearDiscovered = -8000;         //ELEMENT info
            h.atomicMass = 63546;
            h.electronConf = "3d10 4s1";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/f/f0/NatCopper.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox187_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Zinc";
            h.number = 30;
            h.oxidationState = "+2";
            h.sign = "Zn";
            h.yearDiscovered = 1746;         //ELEMENT info
            h.atomicMass = 65390;
            h.electronConf = "3d10 4s2";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/f/f0/NatCopper.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox147_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Helium";
            h.number = 2;
            h.oxidationState = "0";
            h.sign = "He";
            h.yearDiscovered = 1868;         //ELEMENT info
            h.atomicMass = 4;
            h.electronConf = "1s2";
            h.picAddress = @"https://d1whtlypfis84e.cloudfront.net/guides/wp-content/uploads/2020/01/23153045/600px-Glowing_ultrapure_helium.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox149_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Neon";
            h.number = 10;
            h.oxidationState = "0";
            h.sign = "Ne";
            h.yearDiscovered = 1898;         //ELEMENT info
            h.atomicMass = 20;
            h.electronConf = "1s2 2s2 2p6";
            h.picAddress = @"https://www.schoolmykids.com/tools/static/images/elements/neon.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox151_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Fluorine";
            h.number = 9;
            h.oxidationState = "-1";
            h.sign = "F";
            h.yearDiscovered = 1886;         //ELEMENT info
            h.atomicMass = 18;
            h.electronConf = "1s2 2s2 2p5";
            h.picAddress = @"https://memepedia.ru/wp-content/uploads/2018/08/p8.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox153_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Oxygen";
            h.number = 8;
            h.oxidationState = "-1, -2, +2";
            h.sign = "O";
            h.yearDiscovered = 1772;         //ELEMENT info
            h.atomicMass = 15999;
            h.electronConf = "1s2 2s2 2p4";
            h.picAddress = @"https://sciencenotes.org/wp-content/uploads/2015/04/Oxygen_Tile.png";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox155_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Nitrogen";
            h.number = 7;
            h.oxidationState = "-3, +3, +5";
            h.sign = "N";
            h.yearDiscovered = 1772;         //ELEMENT info
            h.atomicMass = 14007;
            h.electronConf = "1s2 2s2 2p3";
            h.picAddress = @"https://i0.wp.com/atenciogabriel.com/wp-content/uploads/2021/02/liquidnitrogenhealthland-1.jpg?fit=600%2C400&ssl=1";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox157_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Carbon";
            h.number = 6;
            h.oxidationState = "+2, +3, +4";
            h.sign = "C";
            h.yearDiscovered = -3500;         //ELEMENT info
            h.atomicMass = 12011;
            h.electronConf = "1s2 2s2 2p2";
            h.picAddress = @"https://www.schoolmykids.com/tools/static/images/elements/carbon.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox148_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Argon";
            h.number = 18;
            h.oxidationState = "0";
            h.sign = "Ar";
            h.yearDiscovered = 1894;         //ELEMENT info
            h.atomicMass = 39792;
            h.electronConf = "1s2 2s2 2p6 3s2 3p6";
            h.picAddress = @"https://static.wikia.nocookie.net/exodus3000/images/a/ae/Ar.jpg/revision/latest/scale-to-width-down/1203?cb=20100521193115";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox150_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Chlorine";
            h.number = 17;
            h.oxidationState = "-1, +1, +3, +5, +7";
            h.sign = "Cl";
            h.yearDiscovered = 1774;         //ELEMENT info
            h.atomicMass = 35446;
            h.electronConf = "1s2 2s2 2p6 3s2 3p5";
            h.picAddress = @"https://spiritstone.pro/wp-content/uploads/2019/08/Ris-1.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox152_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Sulfur";
            h.number = 16;
            h.oxidationState = "-2, +4, +6";
            h.sign = "S";
            h.yearDiscovered = -4000;         //ELEMENT info
            h.atomicMass = 32064;
            h.electronConf = "1s2 2s2 2p6 3s2 3p4";
            h.picAddress = @"https://science4fun.info/wp-content/uploads/2017/09/sulfur-element.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox154_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Phosphorus";
            h.number = 15;
            h.oxidationState = "-3, +3, +5";
            h.sign = "P";
            h.yearDiscovered = 1669;         //ELEMENT info
            h.atomicMass = 30973;
            h.electronConf = "1s2 2s2 2p6 3s2 3p3";
            h.picAddress = @"https://xcook.info/wp-content/uploads/sites/default/files/resize/products/6/fosfor-3-350x263.jpeg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox156_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Silicon";
            h.number = 14;
            h.oxidationState = "-4, +2, +4";
            h.sign = "Si";
            h.yearDiscovered = 1824;         //ELEMENT info
            h.atomicMass = 28086;
            h.electronConf = "1s2 2s2 2p6 3s2 3p2";
            h.picAddress = @"https://bcdn.products.pcc.eu/wp-content/uploads/2021/11/fot2-silikony.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox158_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Aluminum";
            h.number = 13;
            h.oxidationState = "+3";
            h.sign = "Al";
            h.yearDiscovered = 1825;         //ELEMENT info
            h.atomicMass = 26981;
            h.electronConf = "1s2 2s2 2p6 3s2 3p1";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Aluminium-4.jpg/640px-Aluminium-4.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox163_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Krypton";
            h.number = 36;
            h.oxidationState = "0, +2";
            h.sign = "Kr";
            h.yearDiscovered = 1898;         //ELEMENT info
            h.atomicMass = 83798;
            h.electronConf = "3d10 4s2 4p6";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Krypton-glow.jpg/600px-Krypton-glow.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox167_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Bromine";
            h.number = 35;
            h.oxidationState = "−1, +1, +3, +5, +7";
            h.sign = "Br";
            h.yearDiscovered = 1826;         //ELEMENT info
            h.atomicMass = 79901;
            h.electronConf = "3d10 4s2 4p5";
            h.picAddress = @"https://images-of-elements.com/pse/brom-3.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox171_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Selenium";
            h.number = 34;
            h.oxidationState = "−2, +4, +6";
            h.sign = "Se";
            h.yearDiscovered = 1817;         //ELEMENT info
            h.atomicMass = 78960;
            h.electronConf = "1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p4";
            h.picAddress = @"https://mineralpro.ru/wp-content/uploads/selen/selen5.jpeg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox175_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Arsenic";
            h.number = 33;
            h.oxidationState = "-3, +3, +5";
            h.sign = "As";
            h.yearDiscovered = 1250;         //ELEMENT info
            h.atomicMass = 74921;
            h.electronConf = "1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p3";
            h.picAddress = @"https://in-w.ru/wp-content/uploads/2016/08/Mishyak.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox179_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Germanium";
            h.number = 32;
            h.oxidationState = "+2, +4";
            h.sign = "Ge";
            h.yearDiscovered = 1886;         //ELEMENT info
            h.atomicMass = 72630;
            h.electronConf = "1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p2";
            h.picAddress = @"https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Polycrystalline-germanium.jpg/250px-Polycrystalline-germanium.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }

        private void pictureBox183_Click(object sender, EventArgs e)
        {
            element h = new element();
            h.name = "Gallium";
            h.number = 31;
            h.oxidationState = "+3";
            h.sign = "Ga";
            h.yearDiscovered = 1875;         //ELEMENT info
            h.atomicMass = 69723;
            h.electronConf = "3d10 4s2 4p1";
            h.picAddress = @"https://www.instituteofmaking.org.uk/images/sized/assets/_images/materials-library/135_Main-600x600.jpg";
            Form2 forma = new Form2(h.name, h.atomicMass.ToString(), h.number.ToString(), h.oxidationState, h.sign, h.electronConf, h.yearDiscovered.ToString(), h.picAddress);
            forma.Show();
        }
    }
}
