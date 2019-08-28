using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace LeafSoft
{
    static class Program
    {
        //static string _exeName = ConfigurationManager.AppSettings["exeName"];
        //static string _exeDir = AppDomain.CurrentDomain.BaseDirectory;
        //static string _startExePath = Path.Combine(_exeDir, _exeName);
        //static EventLog log = new EventLog() { Source = Path.GetFileNameWithoutExtension(_exeName) };
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //加载日志配置文件，只需要在程序启动时加载一次
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "app.config";
                LogHelper.SetConfig(filePath);
                //log4net.Config.XmlConfigurator.Configure();
                LogHelper.WriteLog("Multi-tool Start: Running...");

                /*
                if (string.IsNullOrEmpty(_exeName))
                {
                    //log.WriteEntry("no set exe name", EventLogEntryType.Error);
                }
                else
                {
                    if (!IsAdmin())
                    {
                        //是否有完全控制权限
                        if (CheckFolderPermissions(_exeDir, FileSystemRights.FullControl))
                        {
                            //运行主进程，不弹出UAC窗口
                            //RunAsAdmin(false);
                            Application.Run(new MainForm());
                        }
                        else
                        {
                            //弹出UAC窗口，以管理员身份运行程序，并在主程序中，进行文件夹授权
                            RunAsAdmin(true);
                        }
                    }
                    else
                    {
                        //运行主进程，不弹出UAC窗口
                        RunAsAdmin(false);
                    }

                }
                */
                Application.Run(new MainForm());

            }
            catch (Exception e)
            {
                ExceptionLog.getLog().WriteLogFile(e, "LogFile.txt");
            }
        }

        /*
        /// <summary>
        /// 检查文件夹权限
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="accessType"></param>
        /// <returns></returns>
        public static bool CheckFolderPermissions(string dirPath, FileSystemRights accessType)
        {
            bool havePermission = false;
            try
            {
                AuthorizationRuleCollection collection = Directory.
                                          GetAccessControl(dirPath)
                                          .GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
                foreach (FileSystemAccessRule rule in collection)
                {
                    if ((rule.FileSystemRights & accessType) > 0)
                    {
                        havePermission = true;
                        break;
                    }
                }

            }
            catch
            {
                havePermission = false;
            }
            return havePermission;
        }

        /// <summary>
        /// 以管理员身份运行，弹出UAC控制窗口
        /// </summary>
        /// <param name="isRunAsAdmin">是否弹出uac控制</param>
        private static void RunAsAdmin(bool isRunAsAdmin)
        {
            //创建启动对象 
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            //设置运行文件 
            startInfo.FileName = _startExePath;
            if (isRunAsAdmin)
            {
                //设置启动动作,确保以管理员身份运行 
                startInfo.Verb = "runas";
                //Application.Run(new MainForm());
            }
            if (File.Exists(_startExePath))
            {
                //如果不是管理员，则启动UAC 
                System.Diagnostics.Process.Start(startInfo);
            }
            else
            {
                //log.WriteEntry("not find the appication to run", EventLogEntryType.Error);
            }

        }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        /// <returns></returns>
        static bool IsAdmin()
        {
            try
            {
                System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
                return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
            catch
            {
                return false;
            }
        }
        */
    }
}
