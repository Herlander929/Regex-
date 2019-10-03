namespace AutoMan
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAlfabetoAtual = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.btnValidaAutomato = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmTransicao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditarTransicao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcluirTransicao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditarEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetEstadoInicial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetFinal = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDados = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAFN_ANFDE = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdicionarSimbolo = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoverSimbolo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdicionarEstado = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoverEstado = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autômatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarSímboloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerSímboloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.adicionarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gustavoAugustoHennigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAFND_E_AFND = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnAnalisarSentenca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(487, 451);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // lblAlfabetoAtual
            // 
            this.lblAlfabetoAtual.BackColor = System.Drawing.Color.White;
            this.lblAlfabetoAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlfabetoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlfabetoAtual.Location = new System.Drawing.Point(23, 31);
            this.lblAlfabetoAtual.Name = "lblAlfabetoAtual";
            this.lblAlfabetoAtual.Size = new System.Drawing.Size(224, 22);
            this.lblAlfabetoAtual.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblDetalhes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(516, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Autômato";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.Location = new System.Drawing.Point(6, 18);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(257, 61);
            this.lblDetalhes.TabIndex = 0;
            // 
            // btnValidaAutomato
            // 
            this.btnValidaAutomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidaAutomato.ForeColor = System.Drawing.Color.Black;
            this.btnValidaAutomato.Location = new System.Drawing.Point(23, 21);
            this.btnValidaAutomato.Name = "btnValidaAutomato";
            this.btnValidaAutomato.Size = new System.Drawing.Size(124, 30);
            this.btnValidaAutomato.TabIndex = 0;
            this.btnValidaAutomato.Text = "Valida Autômato";
            this.btnValidaAutomato.UseVisualStyleBackColor = true;
            this.btnValidaAutomato.Click += new System.EventHandler(this.btnValidaAutomato_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTransicao,
            this.tsmEditarTransicao,
            this.tsmExcluirTransicao,
            this.toolStripSeparator1,
            this.tsmEstado,
            this.tsmEditarEstado,
            this.tsmSetEstadoInicial,
            this.tsmSetFinal});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(216, 164);
            // 
            // tsmTransicao
            // 
            this.tsmTransicao.Enabled = false;
            this.tsmTransicao.Name = "tsmTransicao";
            this.tsmTransicao.Size = new System.Drawing.Size(215, 22);
            this.tsmTransicao.Text = "Transição";
            // 
            // tsmEditarTransicao
            // 
            this.tsmEditarTransicao.Name = "tsmEditarTransicao";
            this.tsmEditarTransicao.Size = new System.Drawing.Size(215, 22);
            this.tsmEditarTransicao.Text = "Editar Transição";
            this.tsmEditarTransicao.Click += new System.EventHandler(this.tsmEditarTransicao_Click);
            // 
            // tsmExcluirTransicao
            // 
            this.tsmExcluirTransicao.Name = "tsmExcluirTransicao";
            this.tsmExcluirTransicao.Size = new System.Drawing.Size(215, 22);
            this.tsmExcluirTransicao.Text = "Excluir Transição";
            this.tsmExcluirTransicao.Click += new System.EventHandler(this.tsmExcluirTransicao_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // tsmEstado
            // 
            this.tsmEstado.Enabled = false;
            this.tsmEstado.Name = "tsmEstado";
            this.tsmEstado.Size = new System.Drawing.Size(215, 22);
            this.tsmEstado.Text = "Estado";
            // 
            // tsmEditarEstado
            // 
            this.tsmEditarEstado.Name = "tsmEditarEstado";
            this.tsmEditarEstado.Size = new System.Drawing.Size(215, 22);
            this.tsmEditarEstado.Text = "Editar Estado";
            this.tsmEditarEstado.Click += new System.EventHandler(this.tsmEditarEstado_Click);
            // 
            // tsmSetEstadoInicial
            // 
            this.tsmSetEstadoInicial.Name = "tsmSetEstadoInicial";
            this.tsmSetEstadoInicial.Size = new System.Drawing.Size(215, 22);
            this.tsmSetEstadoInicial.Text = "Definir como Estado Inicial";
            this.tsmSetEstadoInicial.Click += new System.EventHandler(this.tsmSetEstadoInicial_Click);
            // 
            // tsmSetFinal
            // 
            this.tsmSetFinal.Name = "tsmSetFinal";
            this.tsmSetFinal.Size = new System.Drawing.Size(215, 22);
            this.tsmSetFinal.Text = "Trocar: Final / Não Final";
            this.tsmSetFinal.Click += new System.EventHandler(this.tsmSetFinal_Click);
            // 
            // lblDados
            // 
            this.lblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDados.Location = new System.Drawing.Point(11, 25);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(252, 104);
            this.lblDados.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblDados);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(516, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 141);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Erros no Autômato";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lblAlfabetoAtual);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(516, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 71);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Afabeto Atual";
            // 
            // btnAFN_ANFDE
            // 
            this.btnAFN_ANFDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFN_ANFDE.ForeColor = System.Drawing.Color.Black;
            this.btnAFN_ANFDE.Location = new System.Drawing.Point(23, 57);
            this.btnAFN_ANFDE.Name = "btnAFN_ANFDE";
            this.btnAFN_ANFDE.Size = new System.Drawing.Size(124, 30);
            this.btnAFN_ANFDE.TabIndex = 1;
            this.btnAFN_ANFDE.Text = "AFND -> AFD";
            this.btnAFN_ANFDE.UseVisualStyleBackColor = true;
            this.btnAFN_ANFDE.Click += new System.EventHandler(this.btnAFN_ANFDE_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdicionarSimbolo,
            this.tsbRemoverSimbolo,
            this.toolStripSeparator2,
            this.tsbAdicionarEstado,
            this.tsbRemoverEstado,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdicionarSimbolo
            // 
            this.tsbAdicionarSimbolo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdicionarSimbolo.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdicionarSimbolo.Image")));
            this.tsbAdicionarSimbolo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdicionarSimbolo.Name = "tsbAdicionarSimbolo";
            this.tsbAdicionarSimbolo.Size = new System.Drawing.Size(109, 22);
            this.tsbAdicionarSimbolo.Text = "Adicionar Símbolo";
            this.tsbAdicionarSimbolo.ToolTipText = "Adicionar Símbolo (Alt + A)";
            this.tsbAdicionarSimbolo.Click += new System.EventHandler(this.btnAdicionarSimbolo_Click);
            // 
            // tsbRemoverSimbolo
            // 
            this.tsbRemoverSimbolo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRemoverSimbolo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoverSimbolo.Image")));
            this.tsbRemoverSimbolo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoverSimbolo.Name = "tsbRemoverSimbolo";
            this.tsbRemoverSimbolo.Size = new System.Drawing.Size(105, 22);
            this.tsbRemoverSimbolo.Text = "Remover Símbolo";
            this.tsbRemoverSimbolo.ToolTipText = "Remover Símbolo (Alt + R)";
            this.tsbRemoverSimbolo.Click += new System.EventHandler(this.btnRemoverSimbolo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAdicionarEstado
            // 
            this.tsbAdicionarEstado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdicionarEstado.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdicionarEstado.Image")));
            this.tsbAdicionarEstado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdicionarEstado.Name = "tsbAdicionarEstado";
            this.tsbAdicionarEstado.Size = new System.Drawing.Size(100, 22);
            this.tsbAdicionarEstado.Text = "Adicionar Estado";
            this.tsbAdicionarEstado.ToolTipText = "Adicionar Estado (Alt + Q)";
            this.tsbAdicionarEstado.Click += new System.EventHandler(this.btnAdicionarEstado_Click);
            // 
            // tsbRemoverEstado
            // 
            this.tsbRemoverEstado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRemoverEstado.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoverEstado.Image")));
            this.tsbRemoverEstado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoverEstado.Name = "tsbRemoverEstado";
            this.tsbRemoverEstado.Size = new System.Drawing.Size(96, 22);
            this.tsbRemoverEstado.Text = "Remover Estado";
            this.tsbRemoverEstado.ToolTipText = "Remover Estado (Alt + D)";
            this.tsbRemoverEstado.Click += new System.EventHandler(this.btnRemoverEstado_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(140, 22);
            this.toolStripLabel1.Text = "Gustavo Augusto Hennig";
            this.toolStripLabel1.Click += new System.EventHandler(this.gustavoAugustoHennigToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.autômatoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // autômatoToolStripMenuItem
            // 
            this.autômatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarSímboloToolStripMenuItem,
            this.removerSímboloToolStripMenuItem,
            this.toolStripMenuItem2,
            this.adicionarEstadoToolStripMenuItem,
            this.removerEstadoToolStripMenuItem});
            this.autômatoToolStripMenuItem.Name = "autômatoToolStripMenuItem";
            this.autômatoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.autômatoToolStripMenuItem.Text = "Autômato";
            // 
            // adicionarSímboloToolStripMenuItem
            // 
            this.adicionarSímboloToolStripMenuItem.Name = "adicionarSímboloToolStripMenuItem";
            this.adicionarSímboloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.adicionarSímboloToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.adicionarSímboloToolStripMenuItem.Text = "Adicionar Símbolo";
            this.adicionarSímboloToolStripMenuItem.Click += new System.EventHandler(this.btnAdicionarSimbolo_Click);
            // 
            // removerSímboloToolStripMenuItem
            // 
            this.removerSímboloToolStripMenuItem.Name = "removerSímboloToolStripMenuItem";
            this.removerSímboloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.removerSímboloToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.removerSímboloToolStripMenuItem.Text = "Remover Símbolo";
            this.removerSímboloToolStripMenuItem.Click += new System.EventHandler(this.btnRemoverSimbolo_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // adicionarEstadoToolStripMenuItem
            // 
            this.adicionarEstadoToolStripMenuItem.Name = "adicionarEstadoToolStripMenuItem";
            this.adicionarEstadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.adicionarEstadoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.adicionarEstadoToolStripMenuItem.Text = "Adicionar Estado";
            this.adicionarEstadoToolStripMenuItem.Click += new System.EventHandler(this.btnAdicionarEstado_Click);
            // 
            // removerEstadoToolStripMenuItem
            // 
            this.removerEstadoToolStripMenuItem.Name = "removerEstadoToolStripMenuItem";
            this.removerEstadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.removerEstadoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.removerEstadoToolStripMenuItem.Text = "Remover Estado";
            this.removerEstadoToolStripMenuItem.Click += new System.EventHandler(this.btnRemoverEstado_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.sobreOProgramaToolStripMenuItem,
            this.gustavoAugustoHennigToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(204, 6);
            // 
            // sobreOProgramaToolStripMenuItem
            // 
            this.sobreOProgramaToolStripMenuItem.Enabled = false;
            this.sobreOProgramaToolStripMenuItem.Name = "sobreOProgramaToolStripMenuItem";
            this.sobreOProgramaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.sobreOProgramaToolStripMenuItem.Text = "Sobre o Programa";
            // 
            // gustavoAugustoHennigToolStripMenuItem
            // 
            this.gustavoAugustoHennigToolStripMenuItem.Name = "gustavoAugustoHennigToolStripMenuItem";
            this.gustavoAugustoHennigToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gustavoAugustoHennigToolStripMenuItem.Text = "Gustavo Augusto Hennig";
            this.gustavoAugustoHennigToolStripMenuItem.Click += new System.EventHandler(this.gustavoAugustoHennigToolStripMenuItem_Click);
            // 
            // btnAFND_E_AFND
            // 
            this.btnAFND_E_AFND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFND_E_AFND.ForeColor = System.Drawing.Color.Black;
            this.btnAFND_E_AFND.Location = new System.Drawing.Point(23, 93);
            this.btnAFND_E_AFND.Name = "btnAFND_E_AFND";
            this.btnAFND_E_AFND.Size = new System.Drawing.Size(124, 30);
            this.btnAFND_E_AFND.TabIndex = 2;
            this.btnAFND_E_AFND.Text = "AFND - E -> AFND";
            this.btnAFND_E_AFND.UseVisualStyleBackColor = true;
            this.btnAFND_E_AFND.Click += new System.EventHandler(this.btnAFND_E_AFND_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizar.Location = new System.Drawing.Point(168, 21);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(79, 45);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "Minimizar Autômato";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnAnalisarSentenca
            // 
            this.btnAnalisarSentenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisarSentenca.ForeColor = System.Drawing.Color.Black;
            this.btnAnalisarSentenca.Location = new System.Drawing.Point(168, 78);
            this.btnAnalisarSentenca.Name = "btnAnalisarSentenca";
            this.btnAnalisarSentenca.Size = new System.Drawing.Size(79, 45);
            this.btnAnalisarSentenca.TabIndex = 4;
            this.btnAnalisarSentenca.Text = "Analisar Sentença";
            this.btnAnalisarSentenca.UseVisualStyleBackColor = true;
            this.btnAnalisarSentenca.Click += new System.EventHandler(this.btnAnalisarSentenca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnValidaAutomato);
            this.groupBox1.Controls.Add(this.btnAnalisarSentenca);
            this.groupBox1.Controls.Add(this.btnAFN_ANFDE);
            this.groupBox1.Controls.Add(this.btnMinimizar);
            this.groupBox1.Controls.Add(this.btnAFND_E_AFND);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(516, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ferramentas";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Gerenciador de Autômatos Finitos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAlfabetoAtual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnValidaAutomato;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmEditarTransicao;
        private System.Windows.Forms.ToolStripMenuItem tsmEditarEstado;
        private System.Windows.Forms.ToolStripMenuItem tsmExcluirTransicao;
        private System.Windows.Forms.ToolStripMenuItem tsmSetEstadoInicial;
        private System.Windows.Forms.ToolStripMenuItem tsmSetFinal;
        private System.Windows.Forms.ToolStripMenuItem tsmTransicao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmEstado;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAFN_ANFDE;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdicionarSimbolo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRemoverSimbolo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbAdicionarEstado;
        private System.Windows.Forms.ToolStripButton tsbRemoverEstado;
        private System.Windows.Forms.Button btnAFND_E_AFND;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem autômatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarSímboloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerSímboloToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adicionarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gustavoAugustoHennigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sobreOProgramaToolStripMenuItem;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnAnalisarSentenca;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

