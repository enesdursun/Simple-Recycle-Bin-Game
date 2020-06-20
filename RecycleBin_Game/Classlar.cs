using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleBin_Game
{
    class OrganikAtikKutusu : IAtikKutusu   // Organik Atık Kutu
    {
        private int _dolulukOrani;
        private int _doluHacim;
        private int _kapasite;
        public OrganikAtikKutusu(int kapasite)
        {
            _kapasite = kapasite;
        }

        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        public int DoluHacim
        {
            get { return _doluHacim; }
        }
        public int DolulukOrani
        {
            get { return _dolulukOrani; }
        }
        public int BosaltmaPuani
        {
            get { return 0; }
        }
        public bool Ekle(Atik atik)
        {
            if (atik.Hacim < Kapasite - DoluHacim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            {
                return false;
            }
        }
        public void Temizle()
        {
            _doluHacim = 0;
            _dolulukOrani = 0;
        }
        public void Ekle2(Atik atik)
        {
            _doluHacim = _doluHacim + atik.Hacim;
            _dolulukOrani = _doluHacim / 7;
        }

        public void Bosalt2()
        {
            _dolulukOrani = 0;
            _doluHacim = 0;
        }
    }
    class Organik : Atik    // Organik Atık
    {
        public Organik(int hacim) : base(hacim)
        {
        }
    }

    class KagitKutusu : IAtikKutusu     // Kagit Kutu
    {
        private int _dolulukOrani;
        private int _doluHacim;
        private int _kapasite;
        public KagitKutusu(int kapasite)
        {
            _kapasite = kapasite;
        }

        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        public int DoluHacim
        {
            get { return _doluHacim; }
        }
        public int DolulukOrani
        {
            get { return _dolulukOrani; }
        }
        public int BosaltmaPuani
        {
            get { return 0; }
        }
        public bool Ekle(Atik atik)
        {
            if (atik.Hacim < Kapasite - DoluHacim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            {
                return false;
            }
        }
        public void Temizle()
        {
            _doluHacim = 0;
            _dolulukOrani = 0;
        }
        public void Ekle2(Atik atik)
        {
            _doluHacim = _doluHacim + atik.Hacim;
            _dolulukOrani = _doluHacim / 12;
        }

        public void Bosalt2()
        {
            _dolulukOrani = 0;
            _doluHacim = 0;
        }
    }
    class Kagit : Atik      // Kagit
    {
        public Kagit(int hacim) : base(hacim)
        {
        }
    }

    class CamKutusu : IAtikKutusu    // Cam Kutusu
    {
        private int _dolulukOrani;
        private int _doluHacim;
        private int _kapasite;
        public CamKutusu(int kapasite)
        {
            _kapasite = kapasite;
        }

        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        public int DoluHacim
        {
            get { return _doluHacim; }
        }
        public int DolulukOrani
        {
            get { return _dolulukOrani; }
        }
        public int BosaltmaPuani
        {
            get { return 0; }
        }
        public bool Ekle(Atik atik)
        {
            if (atik.Hacim < Kapasite - DoluHacim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            {
                return false;
            }
        }
        public void Temizle()
        {
            _doluHacim = 0;
            _dolulukOrani = 0;
        }
        public void Ekle2(Atik atik)
        {
            _doluHacim = _doluHacim + atik.Hacim;
            _dolulukOrani = _doluHacim / 22;
        }

        public void Bosalt2()
        {
            _dolulukOrani = 0;
            _doluHacim = 0;
        }
    }
    class Cam : Atik    // Cam
    {
        public Cam(int hacim) : base(hacim)
        {
        }
    }

    class MetalKutusu : IAtikKutusu     // Metal Kutusu
    {
        private int _dolulukOrani;
        private int _doluHacim;
        private int _kapasite;
        public MetalKutusu(int kapasite)
        {
            _kapasite = kapasite;
        }

        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        public int DoluHacim
        {
            get { return _doluHacim; }
        }
        public int DolulukOrani
        {
            get { return _dolulukOrani; }
        }
        public int BosaltmaPuani
        {
            get { return 0; }
        }
        public bool Ekle(Atik atik)
        {
            if (atik.Hacim < Kapasite - DoluHacim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            {
                return false;
            }
        }
        public void Temizle()
        {
            _doluHacim = 0;
            _dolulukOrani = 0;
        }
        public void Ekle2(Atik atik)
        {
            _doluHacim = _doluHacim + atik.Hacim;
            _dolulukOrani = _doluHacim / 23;
        }

        public void Bosalt2()
        {
            _dolulukOrani = 0;
            _doluHacim = 0;
        }
    }
    class Metal : Atik      // Metal
    {
        public Metal(int hacim) : base(hacim)
        {
        }
    }

    public class Atik : IAtik
    {
        public Atik(int hacim)
        {
            Hacim = hacim;
        }
        public int Hacim { get; }
        public Image Image { get; }
    }
}