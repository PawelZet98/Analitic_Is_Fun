
namespace Projekt2_Zalewski51343
{
    partial class Analizator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pzbtnKolorLinii = new System.Windows.Forms.Button();
            this.pzbtnKolorTła = new System.Windows.Forms.Button();
            this.pzlblStylLinii = new System.Windows.Forms.Label();
            this.pzcmbStylLinii = new System.Windows.Forms.ComboBox();
            this.pzlblGrubośćLinii = new System.Windows.Forms.Label();
            this.pztbGrubośćLinii = new System.Windows.Forms.TrackBar();
            this.pzlblMinimalnaPróbaBadawcza = new System.Windows.Forms.Label();
            this.pztxtMinimalnaPróbaBadawcza = new System.Windows.Forms.TextBox();
            this.pzlblMaksymalnyRozmiarTablic = new System.Windows.Forms.Label();
            this.pztxtMaksymalnyRozmiarTablicy = new System.Windows.Forms.TextBox();
            this.pzlblDolnaGranicaPrzedziału = new System.Windows.Forms.Label();
            this.pztxtDolnaGranicaPrzedziału = new System.Windows.Forms.TextBox();
            this.pzlblGórnaGranicaPrzedziału = new System.Windows.Forms.Label();
            this.pztxtGórnaGranicaPrzedziału = new System.Windows.Forms.TextBox();
            this.pzlblAlgorytmDoAnalizy = new System.Windows.Forms.Label();
            this.pzcmbAlgorytmDoAnalizy = new System.Windows.Forms.ComboBox();
            this.pzbtnAkceptuj = new System.Windows.Forms.Button();
            this.pzdgvAnalizatorZłożonościObliczeniowej = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pzbtnTabelarycznaPrezentacja = new System.Windows.Forms.Button();
            this.pzbtnGraficznaPrezentacja = new System.Windows.Forms.Button();
            this.pzbtnResetuj = new System.Windows.Forms.Button();
            this.pzbtnWizualizacjaPoSortowaniu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pzchartWykresKosztuCzasowego = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pzdgvPosortowanaTablica = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pzbtnWizualizacjaPrzedSortowaniem = new System.Windows.Forms.Button();
            this.pzpbKolorLinii = new System.Windows.Forms.PictureBox();
            this.pzpbKolorTła = new System.Windows.Forms.PictureBox();
            this.pztxtGrubośćLinii = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pztbGrubośćLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzdgvAnalizatorZłożonościObliczeniowej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzchartWykresKosztuCzasowego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzdgvPosortowanaTablica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzpbKolorLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzpbKolorTła)).BeginInit();
            this.SuspendLayout();
            // 
            // pzbtnKolorLinii
            // 
            this.pzbtnKolorLinii.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pzbtnKolorLinii.Enabled = false;
            this.pzbtnKolorLinii.ForeColor = System.Drawing.Color.Black;
            this.pzbtnKolorLinii.Location = new System.Drawing.Point(666, 155);
            this.pzbtnKolorLinii.Name = "pzbtnKolorLinii";
            this.pzbtnKolorLinii.Size = new System.Drawing.Size(100, 50);
            this.pzbtnKolorLinii.TabIndex = 0;
            this.pzbtnKolorLinii.Text = "Wybierz kolor linii";
            this.pzbtnKolorLinii.UseVisualStyleBackColor = false;
            this.pzbtnKolorLinii.Click += new System.EventHandler(this.pzbtnKolorLinii_Click);
            // 
            // pzbtnKolorTła
            // 
            this.pzbtnKolorTła.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pzbtnKolorTła.Enabled = false;
            this.pzbtnKolorTła.ForeColor = System.Drawing.Color.Black;
            this.pzbtnKolorTła.Location = new System.Drawing.Point(666, 14);
            this.pzbtnKolorTła.Name = "pzbtnKolorTła";
            this.pzbtnKolorTła.Size = new System.Drawing.Size(100, 50);
            this.pzbtnKolorTła.TabIndex = 1;
            this.pzbtnKolorTła.Text = "Wybierz kolor tła";
            this.pzbtnKolorTła.UseVisualStyleBackColor = false;
            this.pzbtnKolorTła.Click += new System.EventHandler(this.pzbtnKolorTła_Click);
            // 
            // pzlblStylLinii
            // 
            this.pzlblStylLinii.AutoSize = true;
            this.pzlblStylLinii.Enabled = false;
            this.pzlblStylLinii.ForeColor = System.Drawing.Color.Black;
            this.pzlblStylLinii.Location = new System.Drawing.Point(663, 102);
            this.pzlblStylLinii.Name = "pzlblStylLinii";
            this.pzlblStylLinii.Size = new System.Drawing.Size(80, 13);
            this.pzlblStylLinii.TabIndex = 2;
            this.pzlblStylLinii.Text = "Wybierz styl linii";
            // 
            // pzcmbStylLinii
            // 
            this.pzcmbStylLinii.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pzcmbStylLinii.Enabled = false;
            this.pzcmbStylLinii.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pzcmbStylLinii.FormattingEnabled = true;
            this.pzcmbStylLinii.Items.AddRange(new object[] {
            "Solid",
            "Dash"});
            this.pzcmbStylLinii.Location = new System.Drawing.Point(666, 118);
            this.pzcmbStylLinii.Name = "pzcmbStylLinii";
            this.pzcmbStylLinii.Size = new System.Drawing.Size(100, 21);
            this.pzcmbStylLinii.TabIndex = 3;
            this.pzcmbStylLinii.SelectedIndexChanged += new System.EventHandler(this.pzcmbStylLinii_SelectedIndexChanged);
            // 
            // pzlblGrubośćLinii
            // 
            this.pzlblGrubośćLinii.AutoSize = true;
            this.pzlblGrubośćLinii.Enabled = false;
            this.pzlblGrubośćLinii.ForeColor = System.Drawing.Color.Black;
            this.pzlblGrubośćLinii.Location = new System.Drawing.Point(663, 245);
            this.pzlblGrubośćLinii.Name = "pzlblGrubośćLinii";
            this.pzlblGrubośćLinii.Size = new System.Drawing.Size(103, 13);
            this.pzlblGrubośćLinii.TabIndex = 4;
            this.pzlblGrubośćLinii.Text = "Wybierz grubość linii";
            // 
            // pztbGrubośćLinii
            // 
            this.pztbGrubośćLinii.Enabled = false;
            this.pztbGrubośćLinii.Location = new System.Drawing.Point(666, 265);
            this.pztbGrubośćLinii.Minimum = 1;
            this.pztbGrubośćLinii.Name = "pztbGrubośćLinii";
            this.pztbGrubośćLinii.Size = new System.Drawing.Size(100, 45);
            this.pztbGrubośćLinii.TabIndex = 5;
            this.pztbGrubośćLinii.Value = 1;
            this.pztbGrubośćLinii.Scroll += new System.EventHandler(this.pztbGrubośćLinii_Scroll);
            // 
            // pzlblMinimalnaPróbaBadawcza
            // 
            this.pzlblMinimalnaPróbaBadawcza.AutoSize = true;
            this.pzlblMinimalnaPróbaBadawcza.ForeColor = System.Drawing.Color.Black;
            this.pzlblMinimalnaPróbaBadawcza.Location = new System.Drawing.Point(9, 466);
            this.pzlblMinimalnaPróbaBadawcza.Name = "pzlblMinimalnaPróbaBadawcza";
            this.pzlblMinimalnaPróbaBadawcza.Size = new System.Drawing.Size(136, 13);
            this.pzlblMinimalnaPróbaBadawcza.TabIndex = 6;
            this.pzlblMinimalnaPróbaBadawcza.Text = "Minimalna próba badawcza\r\n";
            // 
            // pztxtMinimalnaPróbaBadawcza
            // 
            this.pztxtMinimalnaPróbaBadawcza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pztxtMinimalnaPróbaBadawcza.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pztxtMinimalnaPróbaBadawcza.Location = new System.Drawing.Point(12, 521);
            this.pztxtMinimalnaPróbaBadawcza.Name = "pztxtMinimalnaPróbaBadawcza";
            this.pztxtMinimalnaPróbaBadawcza.Size = new System.Drawing.Size(100, 20);
            this.pztxtMinimalnaPróbaBadawcza.TabIndex = 7;
            // 
            // pzlblMaksymalnyRozmiarTablic
            // 
            this.pzlblMaksymalnyRozmiarTablic.AutoSize = true;
            this.pzlblMaksymalnyRozmiarTablic.ForeColor = System.Drawing.Color.Black;
            this.pzlblMaksymalnyRozmiarTablic.Location = new System.Drawing.Point(151, 466);
            this.pzlblMaksymalnyRozmiarTablic.Name = "pzlblMaksymalnyRozmiarTablic";
            this.pzlblMaksymalnyRozmiarTablic.Size = new System.Drawing.Size(192, 13);
            this.pzlblMaksymalnyRozmiarTablic.TabIndex = 8;
            this.pzlblMaksymalnyRozmiarTablic.Text = "Maksymalny rozmiar sortowanych tablic";
            // 
            // pztxtMaksymalnyRozmiarTablicy
            // 
            this.pztxtMaksymalnyRozmiarTablicy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pztxtMaksymalnyRozmiarTablicy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pztxtMaksymalnyRozmiarTablicy.Location = new System.Drawing.Point(154, 521);
            this.pztxtMaksymalnyRozmiarTablicy.Name = "pztxtMaksymalnyRozmiarTablicy";
            this.pztxtMaksymalnyRozmiarTablicy.Size = new System.Drawing.Size(100, 20);
            this.pztxtMaksymalnyRozmiarTablicy.TabIndex = 9;
            // 
            // pzlblDolnaGranicaPrzedziału
            // 
            this.pzlblDolnaGranicaPrzedziału.AutoSize = true;
            this.pzlblDolnaGranicaPrzedziału.ForeColor = System.Drawing.Color.Black;
            this.pzlblDolnaGranicaPrzedziału.Location = new System.Drawing.Point(349, 466);
            this.pzlblDolnaGranicaPrzedziału.Name = "pzlblDolnaGranicaPrzedziału";
            this.pzlblDolnaGranicaPrzedziału.Size = new System.Drawing.Size(125, 39);
            this.pzlblDolnaGranicaPrzedziału.TabIndex = 10;
            this.pzlblDolnaGranicaPrzedziału.Text = "Dolna granica przedziału\r\nwartości elementów\r\nsortowania tablicy";
            // 
            // pztxtDolnaGranicaPrzedziału
            // 
            this.pztxtDolnaGranicaPrzedziału.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pztxtDolnaGranicaPrzedziału.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pztxtDolnaGranicaPrzedziału.Location = new System.Drawing.Point(352, 521);
            this.pztxtDolnaGranicaPrzedziału.Name = "pztxtDolnaGranicaPrzedziału";
            this.pztxtDolnaGranicaPrzedziału.Size = new System.Drawing.Size(100, 20);
            this.pztxtDolnaGranicaPrzedziału.TabIndex = 11;
            // 
            // pzlblGórnaGranicaPrzedziału
            // 
            this.pzlblGórnaGranicaPrzedziału.AutoSize = true;
            this.pzlblGórnaGranicaPrzedziału.ForeColor = System.Drawing.Color.Black;
            this.pzlblGórnaGranicaPrzedziału.Location = new System.Drawing.Point(480, 466);
            this.pzlblGórnaGranicaPrzedziału.Name = "pzlblGórnaGranicaPrzedziału";
            this.pzlblGórnaGranicaPrzedziału.Size = new System.Drawing.Size(126, 39);
            this.pzlblGórnaGranicaPrzedziału.TabIndex = 12;
            this.pzlblGórnaGranicaPrzedziału.Text = "Górna granica przedziału\r\nwartości elementów\r\nsortowania tablicy";
            // 
            // pztxtGórnaGranicaPrzedziału
            // 
            this.pztxtGórnaGranicaPrzedziału.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pztxtGórnaGranicaPrzedziału.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pztxtGórnaGranicaPrzedziału.Location = new System.Drawing.Point(483, 521);
            this.pztxtGórnaGranicaPrzedziału.Name = "pztxtGórnaGranicaPrzedziału";
            this.pztxtGórnaGranicaPrzedziału.Size = new System.Drawing.Size(100, 20);
            this.pztxtGórnaGranicaPrzedziału.TabIndex = 13;
            // 
            // pzlblAlgorytmDoAnalizy
            // 
            this.pzlblAlgorytmDoAnalizy.AutoSize = true;
            this.pzlblAlgorytmDoAnalizy.ForeColor = System.Drawing.Color.Black;
            this.pzlblAlgorytmDoAnalizy.Location = new System.Drawing.Point(612, 466);
            this.pzlblAlgorytmDoAnalizy.Name = "pzlblAlgorytmDoAnalizy";
            this.pzlblAlgorytmDoAnalizy.Size = new System.Drawing.Size(137, 13);
            this.pzlblAlgorytmDoAnalizy.TabIndex = 14;
            this.pzlblAlgorytmDoAnalizy.Text = "Wybierz algorytm do analizy";
            // 
            // pzcmbAlgorytmDoAnalizy
            // 
            this.pzcmbAlgorytmDoAnalizy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pzcmbAlgorytmDoAnalizy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pzcmbAlgorytmDoAnalizy.FormattingEnabled = true;
            this.pzcmbAlgorytmDoAnalizy.Items.AddRange(new object[] {
            "ShakeSort",
            "HeapSort"});
            this.pzcmbAlgorytmDoAnalizy.Location = new System.Drawing.Point(615, 521);
            this.pzcmbAlgorytmDoAnalizy.Name = "pzcmbAlgorytmDoAnalizy";
            this.pzcmbAlgorytmDoAnalizy.Size = new System.Drawing.Size(159, 21);
            this.pzcmbAlgorytmDoAnalizy.TabIndex = 15;
            // 
            // pzbtnAkceptuj
            // 
            this.pzbtnAkceptuj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pzbtnAkceptuj.ForeColor = System.Drawing.Color.Black;
            this.pzbtnAkceptuj.Location = new System.Drawing.Point(12, 548);
            this.pzbtnAkceptuj.Name = "pzbtnAkceptuj";
            this.pzbtnAkceptuj.Size = new System.Drawing.Size(762, 50);
            this.pzbtnAkceptuj.TabIndex = 16;
            this.pzbtnAkceptuj.Text = "Akceptuj";
            this.pzbtnAkceptuj.UseVisualStyleBackColor = false;
            this.pzbtnAkceptuj.Click += new System.EventHandler(this.pzbtnAkceptuj_Click);
            // 
            // pzdgvAnalizatorZłożonościObliczeniowej
            // 
            this.pzdgvAnalizatorZłożonościObliczeniowej.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pzdgvAnalizatorZłożonościObliczeniowej.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.pzdgvAnalizatorZłożonościObliczeniowej.Location = new System.Drawing.Point(12, 70);
            this.pzdgvAnalizatorZłożonościObliczeniowej.Name = "pzdgvAnalizatorZłożonościObliczeniowej";
            this.pzdgvAnalizatorZłożonościObliczeniowej.Size = new System.Drawing.Size(630, 378);
            this.pzdgvAnalizatorZłożonościObliczeniowej.TabIndex = 17;
            this.pzdgvAnalizatorZłożonościObliczeniowej.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Rozmiar sortowanej tabeli";
            this.Column1.Name = "Column1";
            this.Column1.Width = 196;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Koszt czasowy z pomiaru";
            this.Column2.Name = "Column2";
            this.Column2.Width = 196;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Koszt pamięciowy";
            this.Column4.Name = "Column4";
            this.Column4.Width = 196;
            // 
            // pzbtnTabelarycznaPrezentacja
            // 
            this.pzbtnTabelarycznaPrezentacja.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pzbtnTabelarycznaPrezentacja.Enabled = false;
            this.pzbtnTabelarycznaPrezentacja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pzbtnTabelarycznaPrezentacja.Location = new System.Drawing.Point(12, 14);
            this.pzbtnTabelarycznaPrezentacja.Name = "pzbtnTabelarycznaPrezentacja";
            this.pzbtnTabelarycznaPrezentacja.Size = new System.Drawing.Size(100, 50);
            this.pzbtnTabelarycznaPrezentacja.TabIndex = 18;
            this.pzbtnTabelarycznaPrezentacja.Text = "Tabelarczyna prezentacja złożoności";
            this.pzbtnTabelarycznaPrezentacja.UseVisualStyleBackColor = false;
            this.pzbtnTabelarycznaPrezentacja.Click += new System.EventHandler(this.pzbtnTabelarycznaPrezentacja_Click);
            // 
            // pzbtnGraficznaPrezentacja
            // 
            this.pzbtnGraficznaPrezentacja.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pzbtnGraficznaPrezentacja.Enabled = false;
            this.pzbtnGraficznaPrezentacja.ForeColor = System.Drawing.Color.Black;
            this.pzbtnGraficznaPrezentacja.Location = new System.Drawing.Point(118, 12);
            this.pzbtnGraficznaPrezentacja.Name = "pzbtnGraficznaPrezentacja";
            this.pzbtnGraficznaPrezentacja.Size = new System.Drawing.Size(100, 50);
            this.pzbtnGraficznaPrezentacja.TabIndex = 19;
            this.pzbtnGraficznaPrezentacja.Text = "Graficzna prezentacja złożoności";
            this.pzbtnGraficznaPrezentacja.UseVisualStyleBackColor = false;
            this.pzbtnGraficznaPrezentacja.Click += new System.EventHandler(this.pzbtnGraficznaPrezentacja_Click);
            // 
            // pzbtnResetuj
            // 
            this.pzbtnResetuj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pzbtnResetuj.Enabled = false;
            this.pzbtnResetuj.ForeColor = System.Drawing.Color.Black;
            this.pzbtnResetuj.Location = new System.Drawing.Point(542, 14);
            this.pzbtnResetuj.Name = "pzbtnResetuj";
            this.pzbtnResetuj.Size = new System.Drawing.Size(100, 50);
            this.pzbtnResetuj.TabIndex = 20;
            this.pzbtnResetuj.Text = "Resetuj";
            this.pzbtnResetuj.UseVisualStyleBackColor = false;
            this.pzbtnResetuj.Click += new System.EventHandler(this.pzbtnResetuj_Click);
            // 
            // pzbtnWizualizacjaPoSortowaniu
            // 
            this.pzbtnWizualizacjaPoSortowaniu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pzbtnWizualizacjaPoSortowaniu.Enabled = false;
            this.pzbtnWizualizacjaPoSortowaniu.ForeColor = System.Drawing.Color.Black;
            this.pzbtnWizualizacjaPoSortowaniu.Location = new System.Drawing.Point(330, 14);
            this.pzbtnWizualizacjaPoSortowaniu.Name = "pzbtnWizualizacjaPoSortowaniu";
            this.pzbtnWizualizacjaPoSortowaniu.Size = new System.Drawing.Size(100, 50);
            this.pzbtnWizualizacjaPoSortowaniu.TabIndex = 21;
            this.pzbtnWizualizacjaPoSortowaniu.Text = "Wizualizacja tablicy po sortowaniu";
            this.pzbtnWizualizacjaPoSortowaniu.UseVisualStyleBackColor = false;
            this.pzbtnWizualizacjaPoSortowaniu.Click += new System.EventHandler(this.pzbtnWizualizacjaPoSortowaniu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pzchartWykresKosztuCzasowego
            // 
            this.pzchartWykresKosztuCzasowego.BackColor = System.Drawing.Color.SkyBlue;
            this.pzchartWykresKosztuCzasowego.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.pzchartWykresKosztuCzasowego.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pzchartWykresKosztuCzasowego.Legends.Add(legend1);
            this.pzchartWykresKosztuCzasowego.Location = new System.Drawing.Point(12, 70);
            this.pzchartWykresKosztuCzasowego.Name = "pzchartWykresKosztuCzasowego";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pzchartWykresKosztuCzasowego.Series.Add(series1);
            this.pzchartWykresKosztuCzasowego.Size = new System.Drawing.Size(630, 379);
            this.pzchartWykresKosztuCzasowego.TabIndex = 22;
            this.pzchartWykresKosztuCzasowego.Text = "chart1";
            title1.Name = "Title1";
            this.pzchartWykresKosztuCzasowego.Titles.Add(title1);
            this.pzchartWykresKosztuCzasowego.Visible = false;
            // 
            // pzdgvPosortowanaTablica
            // 
            this.pzdgvPosortowanaTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pzdgvPosortowanaTablica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.pzdgvPosortowanaTablica.Location = new System.Drawing.Point(12, 70);
            this.pzdgvPosortowanaTablica.Name = "pzdgvPosortowanaTablica";
            this.pzdgvPosortowanaTablica.Size = new System.Drawing.Size(630, 378);
            this.pzdgvPosortowanaTablica.TabIndex = 23;
            this.pzdgvPosortowanaTablica.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Indeks";
            this.Column5.Name = "Column5";
            this.Column5.Width = 290;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Wartość";
            this.Column6.Name = "Column6";
            this.Column6.Width = 290;
            // 
            // pzbtnWizualizacjaPrzedSortowaniem
            // 
            this.pzbtnWizualizacjaPrzedSortowaniem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pzbtnWizualizacjaPrzedSortowaniem.Enabled = false;
            this.pzbtnWizualizacjaPrzedSortowaniem.ForeColor = System.Drawing.Color.Black;
            this.pzbtnWizualizacjaPrzedSortowaniem.Location = new System.Drawing.Point(224, 14);
            this.pzbtnWizualizacjaPrzedSortowaniem.Name = "pzbtnWizualizacjaPrzedSortowaniem";
            this.pzbtnWizualizacjaPrzedSortowaniem.Size = new System.Drawing.Size(100, 50);
            this.pzbtnWizualizacjaPrzedSortowaniem.TabIndex = 24;
            this.pzbtnWizualizacjaPrzedSortowaniem.Text = "Wizualizacja tablicy przed sortowaniem";
            this.pzbtnWizualizacjaPrzedSortowaniem.UseVisualStyleBackColor = false;
            this.pzbtnWizualizacjaPrzedSortowaniem.Click += new System.EventHandler(this.pzbtnWizualizacjaPrzedSortowaniem_Click);
            // 
            // pzpbKolorLinii
            // 
            this.pzpbKolorLinii.Location = new System.Drawing.Point(666, 211);
            this.pzpbKolorLinii.Name = "pzpbKolorLinii";
            this.pzpbKolorLinii.Size = new System.Drawing.Size(100, 16);
            this.pzpbKolorLinii.TabIndex = 25;
            this.pzpbKolorLinii.TabStop = false;
            // 
            // pzpbKolorTła
            // 
            this.pzpbKolorTła.Location = new System.Drawing.Point(666, 70);
            this.pzpbKolorTła.Name = "pzpbKolorTła";
            this.pzpbKolorTła.Size = new System.Drawing.Size(100, 16);
            this.pzpbKolorTła.TabIndex = 26;
            this.pzpbKolorTła.TabStop = false;
            // 
            // pztxtGrubośćLinii
            // 
            this.pztxtGrubośćLinii.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pztxtGrubośćLinii.Enabled = false;
            this.pztxtGrubośćLinii.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pztxtGrubośćLinii.Location = new System.Drawing.Point(666, 306);
            this.pztxtGrubośćLinii.Name = "pztxtGrubośćLinii";
            this.pztxtGrubośćLinii.Size = new System.Drawing.Size(100, 20);
            this.pztxtGrubośćLinii.TabIndex = 27;
            this.pztxtGrubośćLinii.TextChanged += new System.EventHandler(this.pztxtGrubośćLinii_TextChanged);
            // 
            // Analizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(788, 600);
            this.Controls.Add(this.pztxtGrubośćLinii);
            this.Controls.Add(this.pzpbKolorTła);
            this.Controls.Add(this.pzpbKolorLinii);
            this.Controls.Add(this.pzbtnWizualizacjaPrzedSortowaniem);
            this.Controls.Add(this.pzbtnWizualizacjaPoSortowaniu);
            this.Controls.Add(this.pzbtnResetuj);
            this.Controls.Add(this.pzbtnGraficznaPrezentacja);
            this.Controls.Add(this.pzbtnTabelarycznaPrezentacja);
            this.Controls.Add(this.pzbtnAkceptuj);
            this.Controls.Add(this.pzcmbAlgorytmDoAnalizy);
            this.Controls.Add(this.pzlblAlgorytmDoAnalizy);
            this.Controls.Add(this.pztxtGórnaGranicaPrzedziału);
            this.Controls.Add(this.pzlblGórnaGranicaPrzedziału);
            this.Controls.Add(this.pztxtDolnaGranicaPrzedziału);
            this.Controls.Add(this.pzlblDolnaGranicaPrzedziału);
            this.Controls.Add(this.pztxtMaksymalnyRozmiarTablicy);
            this.Controls.Add(this.pzlblMaksymalnyRozmiarTablic);
            this.Controls.Add(this.pztxtMinimalnaPróbaBadawcza);
            this.Controls.Add(this.pzlblMinimalnaPróbaBadawcza);
            this.Controls.Add(this.pztbGrubośćLinii);
            this.Controls.Add(this.pzlblGrubośćLinii);
            this.Controls.Add(this.pzcmbStylLinii);
            this.Controls.Add(this.pzlblStylLinii);
            this.Controls.Add(this.pzbtnKolorTła);
            this.Controls.Add(this.pzbtnKolorLinii);
            this.Controls.Add(this.pzchartWykresKosztuCzasowego);
            this.Controls.Add(this.pzdgvAnalizatorZłożonościObliczeniowej);
            this.Controls.Add(this.pzdgvPosortowanaTablica);
            this.Name = "Analizator";
            this.Text = "Analizator";
            ((System.ComponentModel.ISupportInitialize)(this.pztbGrubośćLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzdgvAnalizatorZłożonościObliczeniowej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzchartWykresKosztuCzasowego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzdgvPosortowanaTablica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzpbKolorLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzpbKolorTła)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pzbtnKolorLinii;
        private System.Windows.Forms.Button pzbtnKolorTła;
        private System.Windows.Forms.Label pzlblStylLinii;
        private System.Windows.Forms.ComboBox pzcmbStylLinii;
        private System.Windows.Forms.Label pzlblGrubośćLinii;
        private System.Windows.Forms.TrackBar pztbGrubośćLinii;
        private System.Windows.Forms.Label pzlblMinimalnaPróbaBadawcza;
        private System.Windows.Forms.TextBox pztxtMinimalnaPróbaBadawcza;
        private System.Windows.Forms.Label pzlblMaksymalnyRozmiarTablic;
        private System.Windows.Forms.TextBox pztxtMaksymalnyRozmiarTablicy;
        private System.Windows.Forms.Label pzlblDolnaGranicaPrzedziału;
        private System.Windows.Forms.TextBox pztxtDolnaGranicaPrzedziału;
        private System.Windows.Forms.Label pzlblGórnaGranicaPrzedziału;
        private System.Windows.Forms.TextBox pztxtGórnaGranicaPrzedziału;
        private System.Windows.Forms.Label pzlblAlgorytmDoAnalizy;
        private System.Windows.Forms.ComboBox pzcmbAlgorytmDoAnalizy;
        private System.Windows.Forms.Button pzbtnAkceptuj;
        private System.Windows.Forms.DataGridView pzdgvAnalizatorZłożonościObliczeniowej;
        private System.Windows.Forms.Button pzbtnTabelarycznaPrezentacja;
        private System.Windows.Forms.Button pzbtnGraficznaPrezentacja;
        private System.Windows.Forms.Button pzbtnResetuj;
        private System.Windows.Forms.Button pzbtnWizualizacjaPoSortowaniu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pzchartWykresKosztuCzasowego;
        private System.Windows.Forms.DataGridView pzdgvPosortowanaTablica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button pzbtnWizualizacjaPrzedSortowaniem;
        private System.Windows.Forms.PictureBox pzpbKolorTła;
        private System.Windows.Forms.PictureBox pzpbKolorLinii;
        private System.Windows.Forms.TextBox pztxtGrubośćLinii;
    }
}

