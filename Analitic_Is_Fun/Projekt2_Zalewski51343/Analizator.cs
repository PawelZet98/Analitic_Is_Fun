using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Projekt2_Zalewski51343
{
    public partial class Analizator : Form
    {
        static int pzLicznikDlaHeapsort = 0;
        int pzPróbaBadawcza = 10;
        int pzMaksymalnyRozmiarTablicy = 10;
        int pzDolnaGranicaWartości = 10;
        static int pzGórnaGranicaWartości = 100;
        int[] pzTablicaDoSortowania;
        float[] pzWynikiZPomiaru;
        float[] pzWynikiAnalityczne;
        int[] pzTablicaLicznikOperacjiDominujących;
        public Analizator()
        {
            InitializeComponent();
            pztxtMinimalnaPróbaBadawcza.Text = pzPróbaBadawcza.ToString();
            pztxtMaksymalnyRozmiarTablicy.Text = pzMaksymalnyRozmiarTablicy.ToString();
            pztxtDolnaGranicaPrzedziału.Text = pzDolnaGranicaWartości.ToString();
            pztxtGórnaGranicaPrzedziału.Text = pzGórnaGranicaWartości.ToString();
            pzcmbAlgorytmDoAnalizy.SelectedIndex = 0;
        }
        private void pzbtnAkceptuj_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(pztxtMinimalnaPróbaBadawcza.Text, out pzPróbaBadawcza))
            {
                errorProvider1.SetError(pztxtMinimalnaPróbaBadawcza, "W zapisie próby badawczej wystąpił niedozwolony znak.");
                return;
            }
            if (!int.TryParse(pztxtMaksymalnyRozmiarTablicy.Text, out pzMaksymalnyRozmiarTablicy))
            {
                errorProvider1.SetError(pztxtMaksymalnyRozmiarTablicy, "W zapisie maksymalnego rozmiaru tablicy wystąpił niedozwolony znak.");
                return;
            }
            if (!int.TryParse(pztxtDolnaGranicaPrzedziału.Text, out pzDolnaGranicaWartości))
            {
                errorProvider1.SetError(pztxtDolnaGranicaPrzedziału, "W zapisie maksymalnego rozmiaru tablicy wystąpił niedozwolony znak.");
                return;
            }
            if (!int.TryParse(pztxtGórnaGranicaPrzedziału.Text, out pzGórnaGranicaWartości))
            {
                errorProvider1.SetError(pztxtGórnaGranicaPrzedziału, "W zapisie maksymalnego rozmiaru tablicy wystąpił niedozwolony znak.");
                return;
            }
            pzbtnWizualizacjaPrzedSortowaniem.Enabled = true;
            pzTablicaDoSortowania = new int[pzMaksymalnyRozmiarTablicy];
            pzWynikiZPomiaru = new float[pzMaksymalnyRozmiarTablicy];
            pzWynikiAnalityczne = new float[pzMaksymalnyRozmiarTablicy];
            pzTablicaLicznikOperacjiDominujących = new int[pzPróbaBadawcza];
            pzbtnTabelarycznaPrezentacja.Enabled = true;
            pzbtnGraficznaPrezentacja.Enabled = true;
            pzbtnResetuj.Enabled = true;
            pzbtnWizualizacjaPoSortowaniu.Enabled = true;
            pzbtnAkceptuj.Enabled = false;
            pztxtDolnaGranicaPrzedziału.Enabled = false;
            pztxtGórnaGranicaPrzedziału.Enabled = false;
            pztxtMaksymalnyRozmiarTablicy.Enabled = false;
            pztxtMinimalnaPróbaBadawcza.Enabled = false;
            pzcmbAlgorytmDoAnalizy.Enabled = false;
            pzpbKolorLinii.Visible = false;
            pzpbKolorTła.Visible = false;
            pzpbKolorLinii.BackColor = Color.Black;
            pzpbKolorTła.BackColor = Color.LightSalmon;
            pztxtGrubośćLinii.Text = "1";
            pzchartWykresKosztuCzasowego.ChartAreas["ChartArea1"].BackColor = Color.LightSalmon;
            pzchartWykresKosztuCzasowego.Legends["Legend1"].BackColor = Color.LightSalmon;
            pzchartWykresKosztuCzasowego.BackColor = Color.LightSalmon;
        }
        private void pzbtnTabelarycznaPrezentacja_Click(object sender, EventArgs e)
        {
            pztxtGrubośćLinii.Enabled = false;
            pzpbKolorLinii.Visible = false;
            pzpbKolorTła.Visible = false;
            pzbtnWizualizacjaPrzedSortowaniem.Enabled = true;
            pzbtnKolorLinii.Enabled = false;
            pzbtnKolorTła.Enabled = false;
            pzlblGrubośćLinii.Enabled = false;
            pzcmbStylLinii.Enabled = false;
            pzlblStylLinii.Enabled = false;
            pztbGrubośćLinii.Enabled = false;
            pztxtDolnaGranicaPrzedziału.Enabled = false;
            pztxtGórnaGranicaPrzedziału.Enabled = false;
            pztxtMaksymalnyRozmiarTablicy.Enabled = false;
            pztxtMinimalnaPróbaBadawcza.Enabled = false;
            pzcmbAlgorytmDoAnalizy.Enabled = false;
            pzbtnTabelarycznaPrezentacja.Enabled = false;
            pzbtnGraficznaPrezentacja.Enabled = true;
            pzbtnWizualizacjaPoSortowaniu.Enabled = true;
            int pzLicznikOperacjiDominujących;
            float pzSumaOperacjiDominujących, pzŚredniaOperacjiDominujących;
            Random pzRandom = new Random();
            Sortowanie pzAlgorypzySortowania = new Sortowanie();
            for (int i = 0; i < pzMaksymalnyRozmiarTablicy; i++)
            {
                for (int j = 0; j < pzPróbaBadawcza; j++)
                {
                    for (int k = 0; k < pzMaksymalnyRozmiarTablicy; k++)
                    {
                        pzTablicaDoSortowania[k] = (pzRandom.Next(pzDolnaGranicaWartości, pzGórnaGranicaWartości));
                        switch (pzcmbAlgorytmDoAnalizy.SelectedIndex)
                        {
                            case 0:
                                pzLicznikOperacjiDominujących = pzAlgorypzySortowania.pzShakeSort(pzTablicaDoSortowania, i);
                                pzTablicaLicznikOperacjiDominujących[j] = pzLicznikOperacjiDominujących;
                                break;
                            case 1:
                                pzLicznikOperacjiDominujących = pzAlgorypzySortowania.pzHeapSort(ref pzTablicaDoSortowania, i);
                                pzTablicaLicznikOperacjiDominujących[j] = pzLicznikDlaHeapsort;
                                break;
                            default:
                                errorProvider1.SetError(pzbtnTabelarycznaPrezentacja, "Prace nad tym algorypzem nie zostały jeszcze ukończone.");
                                return;
                        }
                    }
                    pzSumaOperacjiDominujących = 0.0F;
                    for (int l = 0; l < pzPróbaBadawcza; l++)
                    {
                        pzSumaOperacjiDominujących = pzSumaOperacjiDominujących + pzTablicaLicznikOperacjiDominujących[l];
                    }
                    pzŚredniaOperacjiDominujących = pzSumaOperacjiDominujących / pzPróbaBadawcza;
                    pzWynikiZPomiaru[i] = pzŚredniaOperacjiDominujących;
                }
                for (int k = 0; k < pzMaksymalnyRozmiarTablicy; k++)
                {
                    pzdgvAnalizatorZłożonościObliczeniowej.Rows.Add();
                    pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[0].Value = k;
                    pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[1].Value = String.Format("{0:F2}", pzWynikiZPomiaru[k]);
                    pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[2].Value = k;
                    if (i % 2 == 0)
                    {
                        pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[0].Style.BackColor = Color.LightBlue;
                        pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[1].Style.BackColor = Color.LightBlue;
                        pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[2].Style.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[0].Style.BackColor = Color.White;
                        pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[1].Style.BackColor = Color.White;
                        pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[2].Style.BackColor = Color.White;
                    }
                    pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    pzdgvAnalizatorZłożonościObliczeniowej.Rows[k].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            pzdgvAnalizatorZłożonościObliczeniowej.Visible = true;
            pzdgvPosortowanaTablica.Visible = false;
            pzchartWykresKosztuCzasowego.Visible = false;
            pzbtnWizualizacjaPoSortowaniu.Enabled = true;
            pzbtnResetuj.Enabled = true;
        }
        private void pzbtnWizualizacjaPoSortowaniu_Click(object sender, EventArgs e)
        {
            pztxtGrubośćLinii.Enabled = false;
            pzLicznikDlaHeapsort = 0;
            pzpbKolorLinii.Visible = false;
            pzpbKolorTła.Visible = false;
            pzbtnWizualizacjaPrzedSortowaniem.Enabled = true;
            pztxtDolnaGranicaPrzedziału.Enabled = false;
            pztxtGórnaGranicaPrzedziału.Enabled = false;
            pztxtMaksymalnyRozmiarTablicy.Enabled = false;
            pztxtMinimalnaPróbaBadawcza.Enabled = false;
            pzcmbAlgorytmDoAnalizy.Enabled = false;
            pzbtnKolorLinii.Enabled = false;
            pzbtnKolorTła.Enabled = false;
            pzlblGrubośćLinii.Enabled = false;
            pzcmbStylLinii.Enabled = false;
            pzlblStylLinii.Enabled = false;
            pztbGrubośćLinii.Enabled = false;
            pzbtnTabelarycznaPrezentacja.Enabled = true;
            pzbtnGraficznaPrezentacja.Enabled = true;
            pzbtnWizualizacjaPoSortowaniu.Enabled = false;
            int pzLicznikOperacjiDominujących;
            Random pzRandom = new Random();
            Sortowanie pzAlgorypzySortowania = new Sortowanie();
            for (int i = 0; i < pzMaksymalnyRozmiarTablicy; i++)
            {
                for (int j = 0; j < pzPróbaBadawcza; j++)
                {
                    for (int k = 0; k < pzMaksymalnyRozmiarTablicy; k++)
                    {
                        pzTablicaDoSortowania[k] = (pzRandom.Next(pzDolnaGranicaWartości, pzGórnaGranicaWartości));
                        switch (pzcmbAlgorytmDoAnalizy.SelectedIndex)
                        {
                            case 0:
                                pzLicznikOperacjiDominujących = pzAlgorypzySortowania.pzShakeSort(pzTablicaDoSortowania, i);
                                pzTablicaLicznikOperacjiDominujących[j] = pzLicznikOperacjiDominujących;
                                break;
                            case 1:
                                pzLicznikOperacjiDominujących = pzAlgorypzySortowania.pzHeapSort(ref pzTablicaDoSortowania, i);
                                pzTablicaLicznikOperacjiDominujących[j] = pzLicznikDlaHeapsort;
                                break;
                            default:
                                errorProvider1.SetError(pzbtnTabelarycznaPrezentacja, "Prace nad tym algorypzem nie zostały jeszcze ukończone.");
                                return;
                        }
                    }
                }
                for (int k = 0; k < pzMaksymalnyRozmiarTablicy; k++)
                {
                    pzdgvPosortowanaTablica.Rows.Add();
                    pzdgvPosortowanaTablica.Rows[k].Cells[0].Value = k;
                    pzdgvPosortowanaTablica.Rows[k].Cells[1].Value = String.Format("{0, 8:F3}", pzTablicaDoSortowania[k]);
                    if (i % 2 == 0)
                    {
                        pzdgvPosortowanaTablica.Rows[k].Cells[0].Style.BackColor = Color.LightBlue;
                        pzdgvPosortowanaTablica.Rows[k].Cells[1].Style.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        pzdgvPosortowanaTablica.Rows[k].Cells[0].Style.BackColor = Color.White;
                        pzdgvPosortowanaTablica.Rows[k].Cells[1].Style.BackColor = Color.White;
                    }
                    pzdgvPosortowanaTablica.Rows[k].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    pzdgvPosortowanaTablica.Rows[k].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            pzdgvAnalizatorZłożonościObliczeniowej.Visible = false;
            pzdgvPosortowanaTablica.Visible = true;
            pzchartWykresKosztuCzasowego.Visible = false;
            pzbtnWizualizacjaPrzedSortowaniem.Enabled = true;
            pzbtnResetuj.Enabled = true;
        }
        class Sortowanie
        {
            public int pzShakeSort(int[] pzTablicaTymczasowa, int n)
            {
                int pzLicznikOperacjiDominujących = 0;
                bool pzzmienione = true;
                int pzstart = 0;
                int pzkoniec = pzTablicaTymczasowa.Length;

                while (pzzmienione == true)
                {
                    pzzmienione = false;

                    for (int pzDzielnikDoOstatniejCyfry = pzstart; pzDzielnikDoOstatniejCyfry < pzkoniec - 1; ++pzDzielnikDoOstatniejCyfry)
                    {
                        
                        if (pzTablicaTymczasowa[pzDzielnikDoOstatniejCyfry] > pzTablicaTymczasowa[pzDzielnikDoOstatniejCyfry + 1])
                        {
                            pzLicznikOperacjiDominujących++;
                            int temp = pzTablicaTymczasowa[pzDzielnikDoOstatniejCyfry];
                            pzTablicaTymczasowa[pzDzielnikDoOstatniejCyfry] = pzTablicaTymczasowa[pzDzielnikDoOstatniejCyfry + 1];
                            pzTablicaTymczasowa[pzDzielnikDoOstatniejCyfry + 1] = temp;
                            pzzmienione = true;
                        }
                    }

                    if (pzzmienione == false)
                        break;

                    pzzmienione = false;
                    pzkoniec = pzkoniec - 1;

                    for (int i = pzkoniec - 1; i >= pzstart; i--)
                    {
                        if (pzTablicaTymczasowa[i] > pzTablicaTymczasowa[i + 1])
                        {
                            pzLicznikOperacjiDominujących++;
                            int temp = pzTablicaTymczasowa[i];
                            pzTablicaTymczasowa[i] = pzTablicaTymczasowa[i + 1];
                            pzTablicaTymczasowa[i + 1] = temp;
                            pzzmienione = true;
                        }
                    }
                    

                    pzstart = pzstart + 1;
                }
                return pzLicznikOperacjiDominujących;

            }

                public int pzHeapSort(ref int[] T, int n)
            {
                int pzRozmiarTablicy = T.Length;
                for (int p = (pzRozmiarTablicy - 1) / 2; p >= 0; --p)
                    pzHeap(ref T, pzRozmiarTablicy, p);

                for (int i = T.Length - 1; i > 0; --i)
                {
                    int pzTymczasowa = T[i];
                    T[i] = T[0];
                    T[0] = pzTymczasowa;

                    --pzRozmiarTablicy;
                    pzHeap(ref T, pzRozmiarTablicy, 0);
                }
                return 0;
            }

            private void pzHeap(ref int[] T, int pzRozmiarTablicy, int pzindex)
            {
                int pzWLewo = (pzindex + 1) * 2 - 1;
                int pzWPrawo = (pzindex + 1) * 2;
                int pzNajwiększaLiczba = 0;
                if (pzWLewo < pzRozmiarTablicy && T[pzWLewo] > T[pzindex])
                {
                    pzNajwiększaLiczba = pzWLewo;
                }
                else
                {
                    pzNajwiększaLiczba = pzindex;
                }
                if (pzWPrawo < pzRozmiarTablicy && T[pzWPrawo] > T[pzNajwiększaLiczba])
                {
                    pzNajwiększaLiczba = pzWPrawo;
                }
                if (pzNajwiększaLiczba != pzindex)
                {
                    pzLicznikDlaHeapsort++;
                    int temp = T[pzindex];
                    T[pzindex] = T[pzNajwiększaLiczba];
                    T[pzNajwiększaLiczba] = temp;
                    pzHeap(ref T, pzRozmiarTablicy, pzNajwiększaLiczba);
                }
            }
        }
        private void pzbtnGraficznaPrezentacja_Click(object sender, EventArgs e)
        {
            pztxtGrubośćLinii.Enabled = true;
            pzLicznikDlaHeapsort = 0;
            pzpbKolorLinii.Visible = true;
            pzpbKolorTła.Visible = true;
            pzbtnWizualizacjaPrzedSortowaniem.Enabled = true;
            pztxtDolnaGranicaPrzedziału.Enabled = false;
            pztxtGórnaGranicaPrzedziału.Enabled = false;
            pztxtMaksymalnyRozmiarTablicy.Enabled = false;
            pztxtMinimalnaPróbaBadawcza.Enabled = false;
            pzcmbAlgorytmDoAnalizy.Enabled = false;
            pzdgvAnalizatorZłożonościObliczeniowej.Visible = false;
            pzdgvPosortowanaTablica.Visible = false;
            pzbtnKolorLinii.Enabled = true;
            pzbtnKolorTła.Enabled = true;
            pzlblGrubośćLinii.Enabled = true;
            pzcmbStylLinii.Enabled = true;
            pzlblStylLinii.Enabled = true;
            pztbGrubośćLinii.Enabled = true;
            pzbtnTabelarycznaPrezentacja.Enabled = true;
            pzbtnGraficznaPrezentacja.Enabled = false;
            pzbtnWizualizacjaPoSortowaniu.Enabled = true;
            int pzLicznikOperacjiDominujących;
            float pzSumaOperacjiDominujących, pzŚredniaOperacjiDominujących;
            Random pzRandom = new Random();
            Sortowanie pzAlgorypzySortowania = new Sortowanie();
            for (int i = 0; i < pzMaksymalnyRozmiarTablicy; i++)
            {
                for (int j = 0; j < pzPróbaBadawcza; j++)
                {
                    for (int k = 0; k < pzMaksymalnyRozmiarTablicy; k++)
                    {
                        pzTablicaDoSortowania[k] = (pzRandom.Next(pzDolnaGranicaWartości, pzGórnaGranicaWartości));
                        switch (pzcmbAlgorytmDoAnalizy.SelectedIndex)
                        {
                            case 0:
                                pzLicznikOperacjiDominujących = pzAlgorypzySortowania.pzShakeSort(pzTablicaDoSortowania, i);
                                pzTablicaLicznikOperacjiDominujących[j] = pzLicznikOperacjiDominujących;
                                break;
                            case 1:
                                pzLicznikOperacjiDominujących = pzAlgorypzySortowania.pzHeapSort(ref pzTablicaDoSortowania, i);
                                pzTablicaLicznikOperacjiDominujących[j] = pzLicznikDlaHeapsort;
                                break;
                            default:
                                errorProvider1.SetError(pzbtnTabelarycznaPrezentacja, "Prace nad tym algorypzem nie zostały jeszcze ukończone.");
                                return;
                        }
                    }
                    pzSumaOperacjiDominujących = 0.0F;
                    for (int l = 0; l < pzPróbaBadawcza; l++)
                    {
                        pzSumaOperacjiDominujących = pzSumaOperacjiDominujących + pzTablicaLicznikOperacjiDominujących[l];
                    }
                    pzŚredniaOperacjiDominujących = pzSumaOperacjiDominujących / pzPróbaBadawcza;
                    pzWynikiZPomiaru[i] = pzŚredniaOperacjiDominujących;
                    switch (pzcmbAlgorytmDoAnalizy.SelectedIndex)
                    {
                        case 0:
                            pzWynikiAnalityczne[i] = (i * (i - 1)) / 2;
                            break;
                        case 1:
                            pzWynikiAnalityczne[i] = ((i * (i - 1)) / 2);
                            break;
                        default:
                            errorProvider1.SetError(pzbtnTabelarycznaPrezentacja, "Prace nad tym algorypzem nie zostały jeszcze ukończone.");
                            return;
                    }
                }
                pzchartWykresKosztuCzasowego.Visible = true;
                pzchartWykresKosztuCzasowego.Titles["Title1"].Text = "Algorypz " + pzcmbAlgorytmDoAnalizy.SelectedItem;
                pzchartWykresKosztuCzasowego.Legends["Legend1"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
                int[] pzRozmiarTabeli = new int[pzMaksymalnyRozmiarTablicy];
                for (int n = 0; n < pzMaksymalnyRozmiarTablicy; n++)
                    pzRozmiarTabeli[n] = n;
                pzchartWykresKosztuCzasowego.Series[0].Name = "Koszt czasowy z pomiaru";
                pzchartWykresKosztuCzasowego.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                pzchartWykresKosztuCzasowego.Series[0].Color = Color.White;
                pzchartWykresKosztuCzasowego.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
                pzchartWykresKosztuCzasowego.Series[0].BorderWidth = 1;
                pzchartWykresKosztuCzasowego.Series[0].Points.DataBindXY(pzRozmiarTabeli, pzWynikiZPomiaru);
                pzbtnGraficznaPrezentacja.Enabled = false;
            }
            pzdgvAnalizatorZłożonościObliczeniowej.Visible = false;
            pzdgvPosortowanaTablica.Visible = false;
            pzchartWykresKosztuCzasowego.Visible = true;
            pzbtnWizualizacjaPoSortowaniu.Enabled = true;
            pzbtnResetuj.Enabled = true;
        }

        private void pzbtnResetuj_Click(object sender, EventArgs e)
        {
            pzbtnWizualizacjaPrzedSortowaniem.Enabled = false;
            pztxtGrubośćLinii.Enabled = false;
            pzLicznikDlaHeapsort = 0;
            pzpbKolorLinii.Visible = false;
            pzpbKolorTła.Visible = false;
            pzbtnKolorLinii.Enabled = false;
            pzbtnKolorTła.Enabled = false;
            pzlblStylLinii.Enabled = false;
            pzcmbStylLinii.Enabled = false;
            pzlblGrubośćLinii.Enabled = false;
            pztbGrubośćLinii.Enabled = false;
            pztxtDolnaGranicaPrzedziału.Enabled = true;
            pztxtDolnaGranicaPrzedziału.Text = "10";
            pztxtGórnaGranicaPrzedziału.Enabled = true;
            pztxtGórnaGranicaPrzedziału.Text = "100";
            pztxtMaksymalnyRozmiarTablicy.Text = "10";
            pztxtMaksymalnyRozmiarTablicy.Enabled = true;
            pztxtMinimalnaPróbaBadawcza.Enabled = true;
            pztxtMinimalnaPróbaBadawcza.Text = "10";
            pzcmbAlgorytmDoAnalizy.Enabled = true;
            pzbtnAkceptuj.Enabled = true;
            pzbtnGraficznaPrezentacja.Enabled = false;
            pzbtnResetuj.Enabled = false;
            pzbtnTabelarycznaPrezentacja.Enabled = false;
            pzdgvAnalizatorZłożonościObliczeniowej.Visible = false;
            pzdgvPosortowanaTablica.Visible = false;
            pzchartWykresKosztuCzasowego.Visible = false;
            pzbtnWizualizacjaPoSortowaniu.Enabled = false;
            pzdgvAnalizatorZłożonościObliczeniowej.Rows.Clear();
            pzdgvPosortowanaTablica.Rows.Clear();
        }

        private void pzbtnWizualizacjaPrzedSortowaniem_Click(object sender, EventArgs e)
        {
            pztxtGrubośćLinii.Enabled = false;
            pzLicznikDlaHeapsort = 0;
            pzpbKolorLinii.Visible = false;
            pzpbKolorTła.Visible = false;
            pzbtnWizualizacjaPrzedSortowaniem.Enabled = true;
            pztxtDolnaGranicaPrzedziału.Enabled = false;
            pztxtGórnaGranicaPrzedziału.Enabled = false;
            pztxtMaksymalnyRozmiarTablicy.Enabled = false;
            pztxtMinimalnaPróbaBadawcza.Enabled = false;
            pzcmbAlgorytmDoAnalizy.Enabled = false;
            pzbtnKolorLinii.Enabled = false;
            pzbtnKolorTła.Enabled = false;
            pzlblGrubośćLinii.Enabled = false;
            pzcmbStylLinii.Enabled = false;
            pzlblStylLinii.Enabled = false;
            pztbGrubośćLinii.Enabled = false;
            pzbtnTabelarycznaPrezentacja.Enabled = true;
            pzbtnGraficznaPrezentacja.Enabled = true;
            pzbtnWizualizacjaPoSortowaniu.Enabled = false;
            Random pzRandom = new Random();
            Sortowanie pzAlgorypzySortowania = new Sortowanie();
            for (int i = 0; i < pzMaksymalnyRozmiarTablicy; i++)
            {
                for (int j = 0; j < pzPróbaBadawcza; j++)
                {
                    for (int k = 0; k < pzMaksymalnyRozmiarTablicy; k++)
                    {
                        pzTablicaDoSortowania[k] = (pzRandom.Next(pzDolnaGranicaWartości, pzGórnaGranicaWartości));
                    }
                }
                for (int k = 0; k < pzMaksymalnyRozmiarTablicy; k++)
                {
                    pzdgvPosortowanaTablica.Rows.Add();
                    pzdgvPosortowanaTablica.Rows[k].Cells[0].Value = k;
                    pzdgvPosortowanaTablica.Rows[k].Cells[1].Value = String.Format("{0, 8:F3}", pzTablicaDoSortowania[k]);
                    if (i % 2 == 0)
                    {
                        pzdgvPosortowanaTablica.Rows[k].Cells[0].Style.BackColor = Color.LightBlue;
                        pzdgvPosortowanaTablica.Rows[k].Cells[1].Style.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        pzdgvPosortowanaTablica.Rows[k].Cells[0].Style.BackColor = Color.White;
                        pzdgvPosortowanaTablica.Rows[k].Cells[1].Style.BackColor = Color.White;
                    }
                    pzdgvPosortowanaTablica.Rows[k].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    pzdgvPosortowanaTablica.Rows[k].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                pzdgvAnalizatorZłożonościObliczeniowej.Visible = false;
                pzdgvPosortowanaTablica.Visible = true;
                pzchartWykresKosztuCzasowego.Visible = false;
                pzbtnWizualizacjaPoSortowaniu.Enabled = true;
                pzbtnWizualizacjaPrzedSortowaniem.Enabled = false;
                pzbtnResetuj.Enabled = true;
            }
        }

        private void pztxtGrubośćLinii_TextChanged(object sender, EventArgs e)
        {
            int pzGrubośćLinii;
            if (!int.TryParse(pztxtGrubośćLinii.Text, out pzGrubośćLinii))
            {
                errorProvider1.SetError(pztxtGrubośćLinii, "W zapisie grubości linii wystąpił niedozwolony znak.");
                return;
            }
            errorProvider1.Dispose();
            if (pzGrubośćLinii > 10 || pzGrubośćLinii < 1)
            {
                errorProvider1.SetError(pztxtGrubośćLinii, "Grubość linii musi mieścić się w przedziale <1, 10>");
                return;
            }
            errorProvider1.Dispose();
            pzchartWykresKosztuCzasowego.Series[0].BorderWidth = pzGrubośćLinii;
            pztbGrubośćLinii.Value = pzGrubośćLinii;
        }

        private void pztbGrubośćLinii_Scroll(object sender, EventArgs e)
        {
            pzchartWykresKosztuCzasowego.Series[0].BorderWidth = pztbGrubośćLinii.Value;
            pztxtGrubośćLinii.Text = pztbGrubośćLinii.Value.ToString();
        }
        private void pzcmbStylLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pzcmbStylLinii.SelectedIndex == 0)
                pzchartWykresKosztuCzasowego.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            else if (pzcmbStylLinii.SelectedIndex == 1)
                pzchartWykresKosztuCzasowego.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
        }
        private void pzbtnKolorTła_Click(object sender, EventArgs e)
        {
            ColorDialog pzcolorPicker = new ColorDialog();
            if (pzcolorPicker.ShowDialog() == DialogResult.OK)
            {
                pzchartWykresKosztuCzasowego.BackColor = pzcolorPicker.Color;
                pzpbKolorTła.BackColor = pzcolorPicker.Color;
                pzchartWykresKosztuCzasowego.ChartAreas["ChartArea1"].BackColor = pzcolorPicker.Color;
                pzchartWykresKosztuCzasowego.Legends["Legend1"].BackColor = pzcolorPicker.Color;
            }
        }
        private void pzbtnKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog pzcolorPicker = new ColorDialog();
            if (pzcolorPicker.ShowDialog() == DialogResult.OK)
            {
                pzchartWykresKosztuCzasowego.Series[0].Color = pzcolorPicker.Color;
                pzpbKolorLinii.BackColor = pzcolorPicker.Color;
            }
        }
    }
}