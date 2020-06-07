using Filosofos.Classes;
using System.Windows.Forms;

namespace Filosofos
{
    public partial class Form1 : Form
    {
        private Label filosofo_1_comeu;
        private Label label1;
        private Label label2;
        private Label filosofo_1_pensou;
        private Label label4;
        private Label filosofo_1_fome;
        private Label label6;
        private Label filosofo_1_tempo;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label filosofo_2_tempo;
        private Label label9;
        private Label filosofo_2_fome;
        private Label label11;
        private Label filosofo_2_pensou;
        private Label label13;
        private Label filosofo_2_comeu;
        private Label label8;
        private Label label10;
        private Label filosofo_3_tempo;
        private Label label14;
        private Label filosofo_3_fome;
        private Label label16;
        private Label filosofo_3_pensou;
        private Label label18;
        private Label filosofo_3_comeu;
        private Label label12;
        private Label label15;
        private Label filosofo_4_tempo;
        private Label label19;
        private Label filosofo_4_fome;
        private Label label21;
        private Label filosofo_4_pensou;
        private Label label23;
        private Label filosofo_4_comeu;
        private Label label17;
        private Label label20;
        private Label filosofo_5_tempo;
        private Label label24;
        private Label filosofo_5_fome;
        private Label label26;
        private Label filosofo_5_pensou;
        private Label label28;
        private Label filosofo_5_comeu;
        private Label label22;
        private Label filosofo_1_status;
        private Label filosofo_2_status;
        private Label label27;
        private Label filosofo_3_status;
        private Label label30;
        private Label filosofo_4_status;
        private Label label32;
        private Label filosofo_5_status;
        private Label label34;
        public Relatorio relatorio;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.relatorio = new Relatorio(this.CallbackRelatorio);
            new Jantar(this.relatorio);
        }

        public void CallbackRelatorio()
        {
            this.filosofo_1_comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 1 Comeu")+"";
            this.filosofo_1_fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 1 Fome") + "";
            this.filosofo_1_pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 1 Pensou") + "";
            this.filosofo_1_tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 1 Tempo") + "";
            this.filosofo_1_status.Text = relatorio.pegaValorDoStatus("Filosofo 1 Status");

            this.filosofo_2_comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 2 Comeu") + "";
            this.filosofo_2_fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 2 Fome") + "";
            this.filosofo_2_pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 2 Pensou") + "";
            this.filosofo_2_tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 2 Tempo") + "";
            this.filosofo_2_status.Text = relatorio.pegaValorDoStatus("Filosofo 2 Status");

            this.filosofo_3_comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 3 Comeu") + "";
            this.filosofo_3_fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 3 Fome") + "";
            this.filosofo_3_pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 3 Pensou") + "";
            this.filosofo_3_tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 3 Tempo") + "";
            this.filosofo_3_status.Text = relatorio.pegaValorDoStatus("Filosofo 3 Status");

            this.filosofo_4_comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 4 Comeu") + "";
            this.filosofo_4_fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 4 Fome") + "";
            this.filosofo_4_pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 4 Pensou") + "";
            this.filosofo_4_tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 4 Tempo") + "";
            this.filosofo_4_status.Text = relatorio.pegaValorDoStatus("Filosofo 4 Status");

            this.filosofo_5_comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 5 Comeu") + "";
            this.filosofo_5_fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 5 Fome") + "";
            this.filosofo_5_pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 5 Pensou") + "";
            this.filosofo_5_tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 5 Tempo") + "";
            this.filosofo_5_status.Text = relatorio.pegaValorDoStatus("Filosofo 5 Status");
        }

        private void InitializeComponent()
        {
            this.filosofo_1_comeu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filosofo_1_pensou = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filosofo_1_fome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filosofo_1_tempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filosofo_2_tempo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.filosofo_2_fome = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.filosofo_2_pensou = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.filosofo_2_comeu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.filosofo_3_tempo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.filosofo_3_fome = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.filosofo_3_pensou = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.filosofo_3_comeu = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.filosofo_4_tempo = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.filosofo_4_fome = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.filosofo_4_pensou = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.filosofo_4_comeu = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.filosofo_5_tempo = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.filosofo_5_fome = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.filosofo_5_pensou = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.filosofo_5_comeu = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.filosofo_1_status = new System.Windows.Forms.Label();
            this.filosofo_2_status = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.filosofo_3_status = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.filosofo_4_status = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.filosofo_5_status = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filosofo_1_comeu
            // 
            this.filosofo_1_comeu.AutoSize = true;
            this.filosofo_1_comeu.Location = new System.Drawing.Point(137, 60);
            this.filosofo_1_comeu.Name = "filosofo_1_comeu";
            this.filosofo_1_comeu.Size = new System.Drawing.Size(13, 13);
            this.filosofo_1_comeu.TabIndex = 0;
            this.filosofo_1_comeu.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "QTD Comeu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "QTD Pensou";
            // 
            // filosofo_1_pensou
            // 
            this.filosofo_1_pensou.AutoSize = true;
            this.filosofo_1_pensou.Location = new System.Drawing.Point(137, 85);
            this.filosofo_1_pensou.Name = "filosofo_1_pensou";
            this.filosofo_1_pensou.Size = new System.Drawing.Size(13, 13);
            this.filosofo_1_pensou.TabIndex = 2;
            this.filosofo_1_pensou.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "QTD Fome";
            // 
            // filosofo_1_fome
            // 
            this.filosofo_1_fome.AutoSize = true;
            this.filosofo_1_fome.Location = new System.Drawing.Point(137, 111);
            this.filosofo_1_fome.Name = "filosofo_1_fome";
            this.filosofo_1_fome.Size = new System.Drawing.Size(13, 13);
            this.filosofo_1_fome.TabIndex = 4;
            this.filosofo_1_fome.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tempo";
            // 
            // filosofo_1_tempo
            // 
            this.filosofo_1_tempo.AutoSize = true;
            this.filosofo_1_tempo.Location = new System.Drawing.Point(137, 134);
            this.filosofo_1_tempo.Name = "filosofo_1_tempo";
            this.filosofo_1_tempo.Size = new System.Drawing.Size(13, 13);
            this.filosofo_1_tempo.TabIndex = 6;
            this.filosofo_1_tempo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filosofo 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filosofo 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tempo";
            // 
            // filosofo_2_tempo
            // 
            this.filosofo_2_tempo.AutoSize = true;
            this.filosofo_2_tempo.Location = new System.Drawing.Point(361, 134);
            this.filosofo_2_tempo.Name = "filosofo_2_tempo";
            this.filosofo_2_tempo.Size = new System.Drawing.Size(13, 13);
            this.filosofo_2_tempo.TabIndex = 15;
            this.filosofo_2_tempo.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "QTD Fome";
            // 
            // filosofo_2_fome
            // 
            this.filosofo_2_fome.AutoSize = true;
            this.filosofo_2_fome.Location = new System.Drawing.Point(361, 111);
            this.filosofo_2_fome.Name = "filosofo_2_fome";
            this.filosofo_2_fome.Size = new System.Drawing.Size(13, 13);
            this.filosofo_2_fome.TabIndex = 13;
            this.filosofo_2_fome.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "QTD Pensou";
            // 
            // filosofo_2_pensou
            // 
            this.filosofo_2_pensou.AutoSize = true;
            this.filosofo_2_pensou.Location = new System.Drawing.Point(361, 85);
            this.filosofo_2_pensou.Name = "filosofo_2_pensou";
            this.filosofo_2_pensou.Size = new System.Drawing.Size(13, 13);
            this.filosofo_2_pensou.TabIndex = 11;
            this.filosofo_2_pensou.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "QTD Comeu";
            // 
            // filosofo_2_comeu
            // 
            this.filosofo_2_comeu.AutoSize = true;
            this.filosofo_2_comeu.Location = new System.Drawing.Point(361, 60);
            this.filosofo_2_comeu.Name = "filosofo_2_comeu";
            this.filosofo_2_comeu.Size = new System.Drawing.Size(13, 13);
            this.filosofo_2_comeu.TabIndex = 9;
            this.filosofo_2_comeu.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Filosofo 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tempo";
            // 
            // filosofo_3_tempo
            // 
            this.filosofo_3_tempo.AutoSize = true;
            this.filosofo_3_tempo.Location = new System.Drawing.Point(597, 134);
            this.filosofo_3_tempo.Name = "filosofo_3_tempo";
            this.filosofo_3_tempo.Size = new System.Drawing.Size(13, 13);
            this.filosofo_3_tempo.TabIndex = 24;
            this.filosofo_3_tempo.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(495, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "QTD Fome";
            // 
            // filosofo_3_fome
            // 
            this.filosofo_3_fome.AutoSize = true;
            this.filosofo_3_fome.Location = new System.Drawing.Point(597, 111);
            this.filosofo_3_fome.Name = "filosofo_3_fome";
            this.filosofo_3_fome.Size = new System.Drawing.Size(13, 13);
            this.filosofo_3_fome.TabIndex = 22;
            this.filosofo_3_fome.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(495, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "QTD Pensou";
            // 
            // filosofo_3_pensou
            // 
            this.filosofo_3_pensou.AutoSize = true;
            this.filosofo_3_pensou.Location = new System.Drawing.Point(597, 85);
            this.filosofo_3_pensou.Name = "filosofo_3_pensou";
            this.filosofo_3_pensou.Size = new System.Drawing.Size(13, 13);
            this.filosofo_3_pensou.TabIndex = 20;
            this.filosofo_3_pensou.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(495, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "QTD Comeu";
            // 
            // filosofo_3_comeu
            // 
            this.filosofo_3_comeu.AutoSize = true;
            this.filosofo_3_comeu.Location = new System.Drawing.Point(597, 60);
            this.filosofo_3_comeu.Name = "filosofo_3_comeu";
            this.filosofo_3_comeu.Size = new System.Drawing.Size(13, 13);
            this.filosofo_3_comeu.TabIndex = 18;
            this.filosofo_3_comeu.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Filosofo 4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Tempo";
            // 
            // filosofo_4_tempo
            // 
            this.filosofo_4_tempo.AutoSize = true;
            this.filosofo_4_tempo.Location = new System.Drawing.Point(137, 350);
            this.filosofo_4_tempo.Name = "filosofo_4_tempo";
            this.filosofo_4_tempo.Size = new System.Drawing.Size(13, 13);
            this.filosofo_4_tempo.TabIndex = 33;
            this.filosofo_4_tempo.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 327);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "QTD Fome";
            // 
            // filosofo_4_fome
            // 
            this.filosofo_4_fome.AutoSize = true;
            this.filosofo_4_fome.Location = new System.Drawing.Point(137, 327);
            this.filosofo_4_fome.Name = "filosofo_4_fome";
            this.filosofo_4_fome.Size = new System.Drawing.Size(13, 13);
            this.filosofo_4_fome.TabIndex = 31;
            this.filosofo_4_fome.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(35, 301);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "QTD Pensou";
            // 
            // filosofo_4_pensou
            // 
            this.filosofo_4_pensou.AutoSize = true;
            this.filosofo_4_pensou.Location = new System.Drawing.Point(137, 301);
            this.filosofo_4_pensou.Name = "filosofo_4_pensou";
            this.filosofo_4_pensou.Size = new System.Drawing.Size(13, 13);
            this.filosofo_4_pensou.TabIndex = 29;
            this.filosofo_4_pensou.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(35, 276);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "QTD Comeu";
            // 
            // filosofo_4_comeu
            // 
            this.filosofo_4_comeu.AutoSize = true;
            this.filosofo_4_comeu.Location = new System.Drawing.Point(137, 276);
            this.filosofo_4_comeu.Name = "filosofo_4_comeu";
            this.filosofo_4_comeu.Size = new System.Drawing.Size(13, 13);
            this.filosofo_4_comeu.TabIndex = 27;
            this.filosofo_4_comeu.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(261, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "Filosofo 5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 350);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Tempo";
            // 
            // filosofo_5_tempo
            // 
            this.filosofo_5_tempo.AutoSize = true;
            this.filosofo_5_tempo.Location = new System.Drawing.Point(362, 350);
            this.filosofo_5_tempo.Name = "filosofo_5_tempo";
            this.filosofo_5_tempo.Size = new System.Drawing.Size(13, 13);
            this.filosofo_5_tempo.TabIndex = 42;
            this.filosofo_5_tempo.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(260, 327);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 13);
            this.label24.TabIndex = 41;
            this.label24.Text = "QTD Fome";
            // 
            // filosofo_5_fome
            // 
            this.filosofo_5_fome.AutoSize = true;
            this.filosofo_5_fome.Location = new System.Drawing.Point(362, 327);
            this.filosofo_5_fome.Name = "filosofo_5_fome";
            this.filosofo_5_fome.Size = new System.Drawing.Size(13, 13);
            this.filosofo_5_fome.TabIndex = 40;
            this.filosofo_5_fome.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(260, 301);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 13);
            this.label26.TabIndex = 39;
            this.label26.Text = "QTD Pensou";
            // 
            // filosofo_5_pensou
            // 
            this.filosofo_5_pensou.AutoSize = true;
            this.filosofo_5_pensou.Location = new System.Drawing.Point(362, 301);
            this.filosofo_5_pensou.Name = "filosofo_5_pensou";
            this.filosofo_5_pensou.Size = new System.Drawing.Size(13, 13);
            this.filosofo_5_pensou.TabIndex = 38;
            this.filosofo_5_pensou.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(260, 276);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 13);
            this.label28.TabIndex = 37;
            this.label28.Text = "QTD Comeu";
            // 
            // filosofo_5_comeu
            // 
            this.filosofo_5_comeu.AutoSize = true;
            this.filosofo_5_comeu.Location = new System.Drawing.Point(362, 276);
            this.filosofo_5_comeu.Name = "filosofo_5_comeu";
            this.filosofo_5_comeu.Size = new System.Drawing.Size(13, 13);
            this.filosofo_5_comeu.TabIndex = 36;
            this.filosofo_5_comeu.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(36, 158);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "Status";
            // 
            // filosofo_1_status
            // 
            this.filosofo_1_status.AutoSize = true;
            this.filosofo_1_status.Location = new System.Drawing.Point(137, 158);
            this.filosofo_1_status.Name = "filosofo_1_status";
            this.filosofo_1_status.Size = new System.Drawing.Size(13, 13);
            this.filosofo_1_status.TabIndex = 46;
            this.filosofo_1_status.Text = "0";
            // 
            // filosofo_2_status
            // 
            this.filosofo_2_status.AutoSize = true;
            this.filosofo_2_status.Location = new System.Drawing.Point(360, 158);
            this.filosofo_2_status.Name = "filosofo_2_status";
            this.filosofo_2_status.Size = new System.Drawing.Size(13, 13);
            this.filosofo_2_status.TabIndex = 48;
            this.filosofo_2_status.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(259, 158);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 13);
            this.label27.TabIndex = 47;
            this.label27.Text = "Status";
            // 
            // filosofo_3_status
            // 
            this.filosofo_3_status.AutoSize = true;
            this.filosofo_3_status.Location = new System.Drawing.Point(596, 158);
            this.filosofo_3_status.Name = "filosofo_3_status";
            this.filosofo_3_status.Size = new System.Drawing.Size(13, 13);
            this.filosofo_3_status.TabIndex = 50;
            this.filosofo_3_status.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(495, 158);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 49;
            this.label30.Text = "Status";
            // 
            // filosofo_4_status
            // 
            this.filosofo_4_status.AutoSize = true;
            this.filosofo_4_status.Location = new System.Drawing.Point(136, 372);
            this.filosofo_4_status.Name = "filosofo_4_status";
            this.filosofo_4_status.Size = new System.Drawing.Size(13, 13);
            this.filosofo_4_status.TabIndex = 52;
            this.filosofo_4_status.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(35, 372);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 51;
            this.label32.Text = "Status";
            // 
            // filosofo_5_status
            // 
            this.filosofo_5_status.AutoSize = true;
            this.filosofo_5_status.Location = new System.Drawing.Point(360, 372);
            this.filosofo_5_status.Name = "filosofo_5_status";
            this.filosofo_5_status.Size = new System.Drawing.Size(13, 13);
            this.filosofo_5_status.TabIndex = 54;
            this.filosofo_5_status.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(259, 372);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 13);
            this.label34.TabIndex = 53;
            this.label34.Text = "Status";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1024, 552);
            this.Controls.Add(this.filosofo_5_status);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.filosofo_4_status);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.filosofo_3_status);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.filosofo_2_status);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.filosofo_1_status);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.filosofo_5_tempo);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.filosofo_5_fome);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.filosofo_5_pensou);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.filosofo_5_comeu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.filosofo_4_tempo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.filosofo_4_fome);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.filosofo_4_pensou);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.filosofo_4_comeu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.filosofo_3_tempo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.filosofo_3_fome);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.filosofo_3_pensou);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.filosofo_3_comeu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filosofo_2_tempo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.filosofo_2_fome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.filosofo_2_pensou);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.filosofo_2_comeu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filosofo_1_tempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filosofo_1_fome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filosofo_1_pensou);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filosofo_1_comeu);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
