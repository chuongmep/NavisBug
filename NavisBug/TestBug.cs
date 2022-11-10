using System.Runtime.InteropServices;
using System.Windows;
using Autodesk.Navisworks.Api.Plugins;
using Speckle.Core.Credentials;
using Speckle.Core.Models;

namespace NavisBug
{
    [Plugin("HelloWorld", "ChuongMep",DisplayName = "HelloWorld", ToolTip = "HelloWorld Speckle")]
    public class TestBug : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            try
            {
                RunProcess();
                MessageBox.Show("Done");
                return 0;
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.ToString());
            }
        }
        async void RunProcess()
        {
            string streamId = "<fill id here>";
            // SQLitePCL.Batteries.Init();
            // define the base object
            List<string> datas = new List<string>() {"1", "2", "3"};
            var commitObject = new Base();
            commitObject["datas"] = datas;
            commitObject.totalChildrenCount = datas.Count;
            Account defaultAccount = AccountManager.GetDefaultAccount();
            MessageBox.Show(defaultAccount.userInfo.name);
            await Task.FromResult(streamId);
        }
    }
}