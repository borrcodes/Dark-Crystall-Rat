using GDBD.Importers;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Expressions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace GDBD.Dispatcher
{
	internal sealed class InitializerBroadcasterDispatcher : Form
	{
		private int m_RequestEvent;

		private IContainer iteratorEvent;

		private TextBox testsEvent;

		private TextBox _MethodEvent;

		private Button m_AuthenticationEvent;

		protected override bool ShowWithoutActivation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return true;
			}
		}

		protected override CreateParams CreateParams
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 8;
				return createParams;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InitializerBroadcasterDispatcher()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_RequestEvent = MappingListAnnotation.m_ConfigurationEvent;
			iteratorEvent = null;
			base._002Ector();
			ChangeFilter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DestroyFilter(object reference, EventArgs ord)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Size primaryMonitorSize = SystemInformation.PrimaryMonitorSize;
			if (base.Location.X < 0)
			{
				base.Location = new Point(0, base.Location.Y);
			}
			if (base.Location.Y < 0)
			{
				base.Location = new Point(base.Location.X, 0);
			}
			if (base.Location.X + base.Size.Width > primaryMonitorSize.Width)
			{
				base.Location = new Point(primaryMonitorSize.Width - base.Size.Width, base.Location.Y);
			}
			if (base.Location.Y + base.Size.Height > primaryMonitorSize.Height)
			{
				base.Location = new Point(base.Location.X, primaryMonitorSize.Height - base.Size.Height);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetFilter(object def, EventArgs cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_RequestEvent = MappingListAnnotation.m_ConfigurationEvent;
			base.TopLevel = true;
			new Thread((ThreadStart)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					while (m_RequestEvent == MappingListAnnotation.m_ConfigurationEvent)
					{
						testsEvent.Invoke((Action)delegate
						{
							//Discarded unreachable code: IL_0002
							//IL_0003: Incompatible stack heights: 0 vs 1
							testsEvent.Lines = DispatcherInstanceExpression.SetupFilter("chat", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent).Split(new string[1]
							{
								"\n"
							}, StringSplitOptions.None);
						});
						testsEvent.Invoke((Action)delegate
						{
							//Discarded unreachable code: IL_0002
							//IL_0003: Incompatible stack heights: 0 vs 1
							testsEvent.SelectionStart = testsEvent.TextLength;
						});
						testsEvent.Invoke((Action)delegate
						{
							//Discarded unreachable code: IL_0002
							//IL_0003: Incompatible stack heights: 0 vs 1
							testsEvent.ScrollToCaret();
						});
						Thread.Sleep(2000);
					}
				}
				catch
				{
				}
			}).Start();
			new Thread((ThreadStart)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				while (m_RequestEvent == MappingListAnnotation.m_ConfigurationEvent)
				{
					Thread.Sleep(500);
				}
				Invoke((Action)delegate
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					Dispose();
				});
			}).Start();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RateFilter(object def, EventArgs connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_MethodEvent.Text.Length > 0)
			{
				DispatcherInstanceExpression.CollectFilter("chat", "\r\n[" + GlobalIssuerImporter.RemoveList() + "]: " + _MethodEvent.Text, MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
				_MethodEvent.Clear();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RemoveFilter(object var1, FormClosingEventArgs cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			cont.Cancel = true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PostFilter(object item, KeyPressEventArgs cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_MethodEvent.Text.Length > 0 && cfg.KeyChar == '\r')
			{
				DispatcherInstanceExpression.CollectFilter("chat", "\r\n[" + GlobalIssuerImporter.RemoveList() + "]: " + _MethodEvent.Text, MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
				_MethodEvent.Clear();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(bool forceinfo)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (forceinfo && iteratorEvent != null)
			{
				iteratorEvent.Dispose();
			}
			Dispose(forceinfo);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(InitializerBroadcasterDispatcher));
			testsEvent = new TextBox();
			_MethodEvent = new TextBox();
			m_AuthenticationEvent = new Button();
			SuspendLayout();
			testsEvent.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			testsEvent.Location = new Point(12, 12);
			testsEvent.MaxLength = 3276799;
			testsEvent.Multiline = true;
			testsEvent.Name = "textBox1";
			testsEvent.ReadOnly = true;
			testsEvent.ScrollBars = ScrollBars.Vertical;
			testsEvent.Size = new Size(490, 313);
			testsEvent.TabIndex = 2;
			testsEvent.TabStop = false;
			_MethodEvent.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			_MethodEvent.BorderStyle = BorderStyle.FixedSingle;
			_MethodEvent.Cursor = Cursors.IBeam;
			_MethodEvent.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 204);
			_MethodEvent.Location = new Point(12, 331);
			_MethodEvent.Name = "textBox2";
			_MethodEvent.Size = new Size(387, 23);
			_MethodEvent.TabIndex = 0;
			_MethodEvent.KeyPress += PostFilter;
			m_AuthenticationEvent.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			m_AuthenticationEvent.FlatStyle = FlatStyle.Flat;
			m_AuthenticationEvent.Location = new Point(405, 331);
			m_AuthenticationEvent.Name = "button1";
			m_AuthenticationEvent.Size = new Size(97, 23);
			m_AuthenticationEvent.TabIndex = 1;
			m_AuthenticationEvent.Text = "Send";
			m_AuthenticationEvent.UseVisualStyleBackColor = true;
			m_AuthenticationEvent.Click += RateFilter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(514, 366);
			base.ControlBox = false;
			base.Controls.Add(m_AuthenticationEvent);
			base.Controls.Add(_MethodEvent);
			base.Controls.Add(testsEvent);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Chat";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			Text = " ";
			base.TopMost = true;
			base.FormClosing += RemoveFilter;
			base.Load += SetFilter;
			base.LocationChanged += DestroyFilter;
			ResumeLayout(performLayout: false);
			PerformLayout();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void CalculateFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				while (m_RequestEvent == MappingListAnnotation.m_ConfigurationEvent)
				{
					testsEvent.Invoke((Action)delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						testsEvent.Lines = DispatcherInstanceExpression.SetupFilter("chat", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent).Split(new string[1]
						{
							"\n"
						}, StringSplitOptions.None);
					});
					testsEvent.Invoke((Action)delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						testsEvent.SelectionStart = testsEvent.TextLength;
					});
					testsEvent.Invoke((Action)delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						testsEvent.ScrollToCaret();
					});
					Thread.Sleep(2000);
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void GetFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			testsEvent.Lines = DispatcherInstanceExpression.SetupFilter("chat", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent).Split(new string[1]
			{
				"\n"
			}, StringSplitOptions.None);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void StartFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			testsEvent.SelectionStart = testsEvent.TextLength;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void ListFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			testsEvent.ScrollToCaret();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void SelectFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (m_RequestEvent == MappingListAnnotation.m_ConfigurationEvent)
			{
				Thread.Sleep(500);
			}
			Invoke((Action)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Dispose();
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void DeleteFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Dispose();
		}
	}
}
