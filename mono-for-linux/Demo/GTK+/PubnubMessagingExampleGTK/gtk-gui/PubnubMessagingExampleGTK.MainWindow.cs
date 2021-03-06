
// This file has been generated by the GUI designer. Do not modify.
namespace PubnubMessagingExampleGTK
{
	public partial class MainWindow
	{
		private global::Gtk.VPaned mainVpanel;
		private global::Gtk.HPaned mainHpanel;
		private global::Gtk.Table actionButtonTable;
		private global::Gtk.Button btnCancel;
		private global::Gtk.Button btnDetailedHistory;
		private global::Gtk.Button btnHereNow;
		private global::Gtk.Button btnPresence;
		private global::Gtk.Button btnPresenceUnsubscribe;
		private global::Gtk.Button btnPublish;
		private global::Gtk.Button btnSettings;
		private global::Gtk.Button btnSubscribe;
		private global::Gtk.Button btnTime;
		private global::Gtk.Button btnUnsubscribe;
		private global::Gtk.VBox subVbox;
		private global::Gtk.HBox line1Hbox;
		private global::Gtk.Label lblSsl;
		private global::Gtk.Entry entrySsl;
		private global::Gtk.Label lblUuid;
		private global::Gtk.Entry entryUuid;
		private global::Gtk.Label lblCipher;
		private global::Gtk.Entry entryCipher;
		private global::Gtk.Label lblTime;
		private global::Gtk.Entry entryServerTime;
		private global::Gtk.HBox hBoxChannelAndConnected;
		private global::Gtk.Notebook notebook3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView tvChannels;
		private global::Gtk.Label label3;
		private global::Gtk.Notebook nbConnectedChannels;
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Button btnShowConnectedUsers;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.TextView tvConnectedUsers;
		private global::Gtk.Label label4;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Notebook notebook5;
		private global::Gtk.ScrolledWindow GtkScrolledWindow4;
		private global::Gtk.TextView tvMessages;
		private global::Gtk.Label label5;
		private global::Gtk.Notebook notebook6;
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Button btnReloadDetailedHistory;
		private global::Gtk.ScrolledWindow GtkScrolledWindow3;
		private global::Gtk.TextView tvDetailedHistory;
		private global::Gtk.Label label7;
		private global::Gtk.Notebook bottomTabs;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView logs;
		private global::Gtk.Label label6;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PubnubMessagingExampleGTK.MainWindow
			this.Name = "PubnubMessagingExampleGTK.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("PubNub Messaging");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.DefaultWidth = 800;
			this.DefaultHeight = 600;
			// Container child PubnubMessagingExampleGTK.MainWindow.Gtk.Container+ContainerChild
			this.mainVpanel = new global::Gtk.VPaned ();
			this.mainVpanel.CanFocus = true;
			this.mainVpanel.Name = "mainVpanel";
			this.mainVpanel.Position = 411;
			this.mainVpanel.BorderWidth = ((uint)(3));
			// Container child mainVpanel.Gtk.Paned+PanedChild
			this.mainHpanel = new global::Gtk.HPaned ();
			this.mainHpanel.CanFocus = true;
			this.mainHpanel.Name = "mainHpanel";
			this.mainHpanel.Position = 200;
			// Container child mainHpanel.Gtk.Paned+PanedChild
			this.actionButtonTable = new global::Gtk.Table (((uint)(13)), ((uint)(3)), false);
			this.actionButtonTable.WidthRequest = 200;
			this.actionButtonTable.Name = "actionButtonTable";
			this.actionButtonTable.RowSpacing = ((uint)(6));
			this.actionButtonTable.ColumnSpacing = ((uint)(6));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnCancel = new global::Gtk.Button ();
			this.btnCancel.CanFocus = true;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseUnderline = true;
			this.btnCancel.Label = global::Mono.Unix.Catalog.GetString ("Cancel");
			this.actionButtonTable.Add (this.btnCancel);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnCancel]));
			w1.TopAttach = ((uint)(4));
			w1.BottomAttach = ((uint)(5));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnDetailedHistory = new global::Gtk.Button ();
			this.btnDetailedHistory.CanFocus = true;
			this.btnDetailedHistory.Name = "btnDetailedHistory";
			this.btnDetailedHistory.UseUnderline = true;
			this.btnDetailedHistory.Label = global::Mono.Unix.Catalog.GetString ("Detailed History");
			this.actionButtonTable.Add (this.btnDetailedHistory);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnDetailedHistory]));
			w2.TopAttach = ((uint)(8));
			w2.BottomAttach = ((uint)(9));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnHereNow = new global::Gtk.Button ();
			this.btnHereNow.CanFocus = true;
			this.btnHereNow.Name = "btnHereNow";
			this.btnHereNow.UseUnderline = true;
			this.btnHereNow.Label = global::Mono.Unix.Catalog.GetString ("Here Now");
			this.actionButtonTable.Add (this.btnHereNow);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnHereNow]));
			w3.TopAttach = ((uint)(9));
			w3.BottomAttach = ((uint)(10));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnPresence = new global::Gtk.Button ();
			this.btnPresence.CanFocus = true;
			this.btnPresence.Name = "btnPresence";
			this.btnPresence.UseUnderline = true;
			this.btnPresence.Label = global::Mono.Unix.Catalog.GetString ("Presence");
			this.actionButtonTable.Add (this.btnPresence);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnPresence]));
			w4.TopAttach = ((uint)(7));
			w4.BottomAttach = ((uint)(8));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnPresenceUnsubscribe = new global::Gtk.Button ();
			this.btnPresenceUnsubscribe.CanFocus = true;
			this.btnPresenceUnsubscribe.Name = "btnPresenceUnsubscribe";
			this.btnPresenceUnsubscribe.UseUnderline = true;
			this.btnPresenceUnsubscribe.Label = global::Mono.Unix.Catalog.GetString ("Presence Unsubscribe");
			this.actionButtonTable.Add (this.btnPresenceUnsubscribe);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnPresenceUnsubscribe]));
			w5.TopAttach = ((uint)(11));
			w5.BottomAttach = ((uint)(12));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnPublish = new global::Gtk.Button ();
			this.btnPublish.CanFocus = true;
			this.btnPublish.Name = "btnPublish";
			this.btnPublish.UseUnderline = true;
			this.btnPublish.Label = global::Mono.Unix.Catalog.GetString ("Publish");
			this.actionButtonTable.Add (this.btnPublish);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnPublish]));
			w6.TopAttach = ((uint)(6));
			w6.BottomAttach = ((uint)(7));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnSettings = new global::Gtk.Button ();
			this.btnSettings.WidthRequest = 180;
			this.btnSettings.CanFocus = true;
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.UseUnderline = true;
			this.btnSettings.Label = global::Mono.Unix.Catalog.GetString ("Settings");
			this.actionButtonTable.Add (this.btnSettings);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnSettings]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnSubscribe = new global::Gtk.Button ();
			this.btnSubscribe.CanFocus = true;
			this.btnSubscribe.Name = "btnSubscribe";
			this.btnSubscribe.UseUnderline = true;
			this.btnSubscribe.Label = global::Mono.Unix.Catalog.GetString ("Subscribe");
			this.actionButtonTable.Add (this.btnSubscribe);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnSubscribe]));
			w8.TopAttach = ((uint)(5));
			w8.BottomAttach = ((uint)(6));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnTime = new global::Gtk.Button ();
			this.btnTime.CanFocus = true;
			this.btnTime.Name = "btnTime";
			this.btnTime.UseUnderline = true;
			this.btnTime.Label = global::Mono.Unix.Catalog.GetString ("Time");
			this.actionButtonTable.Add (this.btnTime);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnTime]));
			w9.TopAttach = ((uint)(12));
			w9.BottomAttach = ((uint)(13));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child actionButtonTable.Gtk.Table+TableChild
			this.btnUnsubscribe = new global::Gtk.Button ();
			this.btnUnsubscribe.CanFocus = true;
			this.btnUnsubscribe.Name = "btnUnsubscribe";
			this.btnUnsubscribe.UseUnderline = true;
			this.btnUnsubscribe.Label = global::Mono.Unix.Catalog.GetString ("Unsubscribe");
			this.actionButtonTable.Add (this.btnUnsubscribe);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.actionButtonTable [this.btnUnsubscribe]));
			w10.TopAttach = ((uint)(10));
			w10.BottomAttach = ((uint)(11));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.mainHpanel.Add (this.actionButtonTable);
			global::Gtk.Paned.PanedChild w11 = ((global::Gtk.Paned.PanedChild)(this.mainHpanel [this.actionButtonTable]));
			w11.Resize = false;
			w11.Shrink = false;
			// Container child mainHpanel.Gtk.Paned+PanedChild
			this.subVbox = new global::Gtk.VBox ();
			this.subVbox.Name = "subVbox";
			this.subVbox.Spacing = 6;
			this.subVbox.BorderWidth = ((uint)(10));
			// Container child subVbox.Gtk.Box+BoxChild
			this.line1Hbox = new global::Gtk.HBox ();
			this.line1Hbox.HeightRequest = 40;
			this.line1Hbox.Name = "line1Hbox";
			this.line1Hbox.Spacing = 6;
			// Container child line1Hbox.Gtk.Box+BoxChild
			this.lblSsl = new global::Gtk.Label ();
			this.lblSsl.Name = "lblSsl";
			this.lblSsl.LabelProp = global::Mono.Unix.Catalog.GetString ("SSL");
			this.line1Hbox.Add (this.lblSsl);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.line1Hbox [this.lblSsl]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child line1Hbox.Gtk.Box+BoxChild
			this.entrySsl = new global::Gtk.Entry ();
			this.entrySsl.WidthRequest = 30;
			this.entrySsl.CanFocus = true;
			this.entrySsl.Name = "entrySsl";
			this.entrySsl.IsEditable = false;
			this.entrySsl.InvisibleChar = '•';
			this.line1Hbox.Add (this.entrySsl);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.line1Hbox [this.entrySsl]));
			w13.Position = 1;
			// Container child line1Hbox.Gtk.Box+BoxChild
			this.lblUuid = new global::Gtk.Label ();
			this.lblUuid.Name = "lblUuid";
			this.lblUuid.LabelProp = global::Mono.Unix.Catalog.GetString ("UUID");
			this.lblUuid.UseUnderline = true;
			this.line1Hbox.Add (this.lblUuid);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.line1Hbox [this.lblUuid]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child line1Hbox.Gtk.Box+BoxChild
			this.entryUuid = new global::Gtk.Entry ();
			this.entryUuid.CanFocus = true;
			this.entryUuid.Name = "entryUuid";
			this.entryUuid.IsEditable = false;
			this.entryUuid.InvisibleChar = '•';
			this.line1Hbox.Add (this.entryUuid);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.line1Hbox [this.entryUuid]));
			w15.Position = 3;
			// Container child line1Hbox.Gtk.Box+BoxChild
			this.lblCipher = new global::Gtk.Label ();
			this.lblCipher.Name = "lblCipher";
			this.lblCipher.LabelProp = global::Mono.Unix.Catalog.GetString ("Cipher");
			this.line1Hbox.Add (this.lblCipher);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.line1Hbox [this.lblCipher]));
			w16.Position = 4;
			w16.Expand = false;
			w16.Fill = false;
			// Container child line1Hbox.Gtk.Box+BoxChild
			this.entryCipher = new global::Gtk.Entry ();
			this.entryCipher.CanFocus = true;
			this.entryCipher.Name = "entryCipher";
			this.entryCipher.IsEditable = false;
			this.entryCipher.InvisibleChar = '•';
			this.line1Hbox.Add (this.entryCipher);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.line1Hbox [this.entryCipher]));
			w17.Position = 5;
			// Container child line1Hbox.Gtk.Box+BoxChild
			this.lblTime = new global::Gtk.Label ();
			this.lblTime.Name = "lblTime";
			this.lblTime.LabelProp = global::Mono.Unix.Catalog.GetString ("Last Request Time");
			this.line1Hbox.Add (this.lblTime);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.line1Hbox [this.lblTime]));
			w18.Position = 6;
			w18.Expand = false;
			w18.Fill = false;
			// Container child line1Hbox.Gtk.Box+BoxChild
			this.entryServerTime = new global::Gtk.Entry ();
			this.entryServerTime.CanFocus = true;
			this.entryServerTime.Name = "entryServerTime";
			this.entryServerTime.IsEditable = false;
			this.entryServerTime.InvisibleChar = '•';
			this.line1Hbox.Add (this.entryServerTime);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.line1Hbox [this.entryServerTime]));
			w19.Position = 7;
			this.subVbox.Add (this.line1Hbox);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.subVbox [this.line1Hbox]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child subVbox.Gtk.Box+BoxChild
			this.hBoxChannelAndConnected = new global::Gtk.HBox ();
			this.hBoxChannelAndConnected.HeightRequest = 20;
			this.hBoxChannelAndConnected.Name = "hBoxChannelAndConnected";
			this.hBoxChannelAndConnected.Spacing = 6;
			this.hBoxChannelAndConnected.BorderWidth = ((uint)(5));
			// Container child hBoxChannelAndConnected.Gtk.Box+BoxChild
			this.notebook3 = new global::Gtk.Notebook ();
			this.notebook3.CanFocus = true;
			this.notebook3.Name = "notebook3";
			this.notebook3.CurrentPage = 0;
			// Container child notebook3.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.tvChannels = new global::Gtk.TextView ();
			this.tvChannels.HeightRequest = 40;
			this.tvChannels.CanFocus = true;
			this.tvChannels.Name = "tvChannels";
			this.GtkScrolledWindow1.Add (this.tvChannels);
			this.notebook3.Add (this.GtkScrolledWindow1);
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Channels Subscribed To");
			this.notebook3.SetTabLabel (this.GtkScrolledWindow1, this.label3);
			this.label3.ShowAll ();
			this.hBoxChannelAndConnected.Add (this.notebook3);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hBoxChannelAndConnected [this.notebook3]));
			w23.Position = 0;
			// Container child hBoxChannelAndConnected.Gtk.Box+BoxChild
			this.nbConnectedChannels = new global::Gtk.Notebook ();
			this.nbConnectedChannels.CanFocus = true;
			this.nbConnectedChannels.Name = "nbConnectedChannels";
			this.nbConnectedChannels.CurrentPage = 0;
			// Container child nbConnectedChannels.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.btnShowConnectedUsers = new global::Gtk.Button ();
			this.btnShowConnectedUsers.CanFocus = true;
			this.btnShowConnectedUsers.Name = "btnShowConnectedUsers";
			this.btnShowConnectedUsers.UseUnderline = true;
			this.btnShowConnectedUsers.Label = global::Mono.Unix.Catalog.GetString ("Run Here Now");
			this.hbox2.Add (this.btnShowConnectedUsers);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnShowConnectedUsers]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox3.Add (this.hbox2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox2]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.tvConnectedUsers = new global::Gtk.TextView ();
			this.tvConnectedUsers.HeightRequest = 20;
			this.tvConnectedUsers.CanFocus = true;
			this.tvConnectedUsers.Name = "tvConnectedUsers";
			this.GtkScrolledWindow2.Add (this.tvConnectedUsers);
			this.vbox3.Add (this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow2]));
			w27.Position = 1;
			this.nbConnectedChannels.Add (this.vbox3);
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Connected Users");
			this.nbConnectedChannels.SetTabLabel (this.vbox3, this.label4);
			this.label4.ShowAll ();
			this.hBoxChannelAndConnected.Add (this.nbConnectedChannels);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hBoxChannelAndConnected [this.nbConnectedChannels]));
			w29.Position = 1;
			this.subVbox.Add (this.hBoxChannelAndConnected);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.subVbox [this.hBoxChannelAndConnected]));
			w30.Position = 1;
			// Container child subVbox.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.notebook5 = new global::Gtk.Notebook ();
			this.notebook5.CanFocus = true;
			this.notebook5.Name = "notebook5";
			this.notebook5.CurrentPage = 0;
			// Container child notebook5.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			this.tvMessages = new global::Gtk.TextView ();
			this.tvMessages.CanFocus = true;
			this.tvMessages.Name = "tvMessages";
			this.GtkScrolledWindow4.Add (this.tvMessages);
			this.notebook5.Add (this.GtkScrolledWindow4);
			// Notebook tab
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Messages");
			this.notebook5.SetTabLabel (this.GtkScrolledWindow4, this.label5);
			this.label5.ShowAll ();
			this.hbox4.Add (this.notebook5);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.notebook5]));
			w33.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.notebook6 = new global::Gtk.Notebook ();
			this.notebook6.CanFocus = true;
			this.notebook6.Name = "notebook6";
			this.notebook6.CurrentPage = 0;
			// Container child notebook6.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.btnReloadDetailedHistory = new global::Gtk.Button ();
			this.btnReloadDetailedHistory.CanFocus = true;
			this.btnReloadDetailedHistory.Name = "btnReloadDetailedHistory";
			this.btnReloadDetailedHistory.UseUnderline = true;
			this.btnReloadDetailedHistory.Label = global::Mono.Unix.Catalog.GetString ("Run History");
			this.hbox5.Add (this.btnReloadDetailedHistory);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.btnReloadDetailedHistory]));
			w34.Position = 2;
			w34.Expand = false;
			w34.Fill = false;
			this.vbox2.Add (this.hbox5);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox5]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.tvDetailedHistory = new global::Gtk.TextView ();
			this.tvDetailedHistory.CanFocus = true;
			this.tvDetailedHistory.Name = "tvDetailedHistory";
			this.GtkScrolledWindow3.Add (this.tvDetailedHistory);
			this.vbox2.Add (this.GtkScrolledWindow3);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow3]));
			w37.Position = 1;
			this.notebook6.Add (this.vbox2);
			// Notebook tab
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Detailed History");
			this.notebook6.SetTabLabel (this.vbox2, this.label7);
			this.label7.ShowAll ();
			this.hbox4.Add (this.notebook6);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.notebook6]));
			w39.Position = 1;
			this.subVbox.Add (this.hbox4);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.subVbox [this.hbox4]));
			w40.PackType = ((global::Gtk.PackType)(1));
			w40.Position = 2;
			this.mainHpanel.Add (this.subVbox);
			global::Gtk.Paned.PanedChild w41 = ((global::Gtk.Paned.PanedChild)(this.mainHpanel [this.subVbox]));
			w41.Resize = false;
			w41.Shrink = false;
			this.mainVpanel.Add (this.mainHpanel);
			global::Gtk.Paned.PanedChild w42 = ((global::Gtk.Paned.PanedChild)(this.mainVpanel [this.mainHpanel]));
			w42.Resize = false;
			w42.Shrink = false;
			// Container child mainVpanel.Gtk.Paned+PanedChild
			this.bottomTabs = new global::Gtk.Notebook ();
			this.bottomTabs.CanFocus = true;
			this.bottomTabs.Name = "bottomTabs";
			this.bottomTabs.CurrentPage = 0;
			// Container child bottomTabs.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.logs = new global::Gtk.TextView ();
			this.logs.CanFocus = true;
			this.logs.Name = "logs";
			this.GtkScrolledWindow.Add (this.logs);
			this.bottomTabs.Add (this.GtkScrolledWindow);
			// Notebook tab
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Logs");
			this.bottomTabs.SetTabLabel (this.GtkScrolledWindow, this.label6);
			this.label6.ShowAll ();
			this.mainVpanel.Add (this.bottomTabs);
			this.Add (this.mainVpanel);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.lblTime.Hide ();
			this.entryServerTime.Hide ();
			this.Show ();
			this.btnUnsubscribe.Clicked += new global::System.EventHandler (this.UnsubscribeClicked);
			this.btnTime.Clicked += new global::System.EventHandler (this.TimeClicked);
			this.btnSubscribe.Clicked += new global::System.EventHandler (this.SubscribeClicked);
			this.btnSettings.Clicked += new global::System.EventHandler (this.SettingsClicked);
			this.btnPublish.Clicked += new global::System.EventHandler (this.PublishClicked);
			this.btnPresenceUnsubscribe.Clicked += new global::System.EventHandler (this.UnsubscribePresenceClicked);
			this.btnPresence.Clicked += new global::System.EventHandler (this.PresenceClicked);
			this.btnHereNow.Clicked += new global::System.EventHandler (this.HereNowClicked);
			this.btnDetailedHistory.Clicked += new global::System.EventHandler (this.DetailedHistoryClicked);
			this.btnShowConnectedUsers.Clicked += new global::System.EventHandler (this.ShowConnectedUsers);
			this.btnReloadDetailedHistory.Clicked += new global::System.EventHandler (this.DetailedHistoryClicked);
		}
	}
}
