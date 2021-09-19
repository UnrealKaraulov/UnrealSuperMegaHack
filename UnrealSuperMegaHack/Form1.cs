using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace UnrealSuperMegaHack
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent( );
        }

        private void button1_Click ( object sender , EventArgs e )
        {
            MessageBox.Show( "Что бы попасть на сайт d3scene.ru\n войдите в браузер и введите адрес сайта!" );
        }
        ProcessMemory war3processmemory = null;


        private void checkBox1_CheckedChanged ( object sender , EventArgs e )
        {
            try
            {
                if ( war3processmemory == null || !war3processmemory.CheckProcess( ) )
                {
                    int war3proclen = Process.GetProcessesByName( "war3" ).Length;
                    if ( war3proclen == 0 )
                    {
                        war3processmemory = null;
                    }
                    else
                    {
                        ProcessMemory war3mem =
                            new ProcessMemory( Process.GetProcessesByName( "war3" ) [ 0 ].Id , "war3" );
                        war3mem.StartProcess( );
                        war3processmemory = war3mem;
                    }
                }
            }
            catch
            {
                war3processmemory = null;
            }



            try
            {
                if ( war3processmemory != null )
                {

                    if ( !war3processmemory.CheckProcess( ) )
                    {
                        war3processmemory = null;

                        return;
                    }


                    int GameDll = war3processmemory.DllImageAddress( "Game.dll" );

                    if ( GameDll == 0 )
                    {
                        war3processmemory = null;

                        return;
                    }




                    int ubratbtuman = checkBox1.Checked ? 1 : 0;

                    war3processmemory.WriteInt( 0xADB0A0 + GameDll , ubratbtuman );

                }
            }
            catch
            {

            }


          /**/
        }

        private void checkBox2_CheckedChanged ( object sender , EventArgs e )
        {
            try
            {
                if ( war3processmemory == null || !war3processmemory.CheckProcess( ) )
                {
                    int war3proclen = Process.GetProcessesByName( "war3" ).Length;
                    if ( war3proclen == 0 )
                    {
                        war3processmemory = null;
                    }
                    else
                    {
                        ProcessMemory war3mem =
                            new ProcessMemory( Process.GetProcessesByName( "war3" ) [ 0 ].Id , "war3" );
                        war3mem.StartProcess( );
                        war3processmemory = war3mem;
                    }
                }
            }
            catch
            {
                war3processmemory = null;
            }



            try
            {
                if ( war3processmemory != null )
                {

                    if ( !war3processmemory.CheckProcess( ) )
                    {
                        war3processmemory = null;

                        return;
                    }


                    int GameDll = war3processmemory.DllImageAddress( "Game.dll" );

                    if ( GameDll == 0 )
                    {
                        war3processmemory = null;

                        return;
                    }


                

                    int ubratbtuman = checkBox2.Checked ? 1 : 0;

                    war3processmemory.WriteInt( 0xACC708 + GameDll , ubratbtuman );

                }
            }
            catch
            {

            }

        }

        private void checkBox3_CheckedChanged ( object sender , EventArgs e )
        {
            try
            {
                if ( war3processmemory == null || !war3processmemory.CheckProcess( ) )
                {
                    int war3proclen = Process.GetProcessesByName( "war3" ).Length;
                    if ( war3proclen == 0 )
                    {
                        war3processmemory = null;
                    }
                    else
                    {
                        ProcessMemory war3mem =
                            new ProcessMemory( Process.GetProcessesByName( "war3" ) [ 0 ].Id , "war3" );
                        war3mem.StartProcess( );
                        war3processmemory = war3mem;
                    }
                }
            }
            catch
            {
                war3processmemory = null;
            }



            try
            {
                if ( war3processmemory != null )
                {

                    if ( !war3processmemory.CheckProcess( ) )
                    {
                        war3processmemory = null;

                        return;
                    }


                    int GameDll = war3processmemory.DllImageAddress( "Game.dll" );

                    if ( GameDll == 0 )
                    {
                        war3processmemory = null;

                        return;
                    }




                    int ubratbtuman = checkBox3.Checked ? 1 : 0;

                    war3processmemory.WriteInt( 0xADF15C + GameDll , ubratbtuman );

                }
            }
            catch
            {

            }
        }

        private void button2_Click ( object sender , EventArgs e )
        {
         
        }

        private void checkBox4_CheckedChanged ( object sender , EventArgs e )
        {
            try
            {
                if ( war3processmemory == null || !war3processmemory.CheckProcess( ) )
                {
                    int war3proclen = Process.GetProcessesByName( "war3" ).Length;
                    if ( war3proclen == 0 )
                    {
                        war3processmemory = null;
                    }
                    else
                    {
                        ProcessMemory war3mem =
                            new ProcessMemory( Process.GetProcessesByName( "war3" ) [ 0 ].Id , "war3" );
                        war3mem.StartProcess( );
                        war3processmemory = war3mem;
                    }
                }
            }
            catch
            {
                war3processmemory = null;
            }



            try
            {
                if ( war3processmemory != null )
                {

                    if ( !war3processmemory.CheckProcess( ) )
                    {
                        war3processmemory = null;

                        return;
                    }


                    int GameDll = war3processmemory.DllImageAddress( "Game.dll" );

                    if ( GameDll == 0 )
                    {
                        war3processmemory = null;

                        return;
                    }


                    int ingame1 = war3processmemory.ReadInt( 0xACF678 + GameDll );
                    int ingame2 = war3processmemory.ReadInt( 0xAB62A4 + GameDll );

                    if ( ingame1 <= 0 && ingame2 <= 0 )
                    {

                        return;
                    }



                    int GlobalUnitClass = war3processmemory.ReadInt( GameDll + 0xAB4F80 );
                    int UnitsArrayClassAddr = war3processmemory.ReadInt( GlobalUnitClass + 0x3BC );

                    int UnitsCount = war3processmemory.ReadInt( UnitsArrayClassAddr + 0x604 );
                    int UnitsArrayAddr = war3processmemory.ReadInt( UnitsArrayClassAddr + 0x608 );

                    for ( int i = 0 ; i < UnitsCount ; i++ )
                    {
                        int CurrentUnitId = i;
                        int CurrentUnitAdress = UnitsArrayAddr + CurrentUnitId * 4;
                        CurrentUnitAdress = war3processmemory.ReadInt( CurrentUnitAdress );
                        uint CurrentUnitFlag = war3processmemory.ReadUInt( CurrentUnitAdress + 724 );
                        war3processmemory.WriteUInt( CurrentUnitAdress + 724 , checkBox4.Checked ? 0xFF000000 : 0xFFFFFFFF );
                    }
                }
            }
            catch
            {

            }
        }
    }
}
