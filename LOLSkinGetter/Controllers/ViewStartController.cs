using System;
using System.Windows.Input;
using Ay.Framework.WPF;
using Ay.Framework.WPF.Controls;
using Ay.Framework.WPF.Shared;
using LOLSkinGetter.Models;

namespace LOLSkinGetter.Controllers
{
    public class ViewStartController : AyPropertyChanged
    {
        public ViewStartModel Model { get; set; }




        public ViewStartController()
        {
            Model = new ViewStartModel();

            DoSomething = str =>
            {
                AyMessageBox.Show("Action方式 " + str.ToString());
            };


            SomeCommand = new SimpleCommand
            {
                ExecuteDelegate = obj =>
                {
                    AyMessageBox.Show("ICommand方式 " + obj.ToString());
                }
            };


            SubmitCommand = new SimpleCommand
            {
                ExecuteDelegate = obj =>
                {
                    AyMessageBox.Show("提交成功，你提交的数据是： " + obj.ToString());
                },
                CanExecuteDelegate = x =>
                {
                    if (x.ToObjectString().IsNullAndTrimAndEmpty())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

            };


            //演示绑定多个操作
            Multy1Command = new SimpleCommand
            {
                ExecuteDelegate = obj =>
                {
                    Model.TextBoxStatus = "Multy1 触发了";
                }
            };

            Multy2Command = new SimpleCommand
            {
                ExecuteDelegate = obj =>
                {
                    Model.TextBoxStatus = "Multy2触发了";
                }
            };

            Multy3Action = x =>
            {
                Model.TextBoxStatus = "Multy3操作 触发了";
            };
        }

        /// <summary>
        /// 原来winform是必须事件，在WPF中，你可以事件，但是不推荐
        /// 现在在AYUI框架里，你可以直接绑定 Action<T>
        /// 第一种命令使用方式DEMO
        /// 备注：前台可以绑定Action类型的
        /// </summary>
        public Action<object> DoSomething { get; private set; }


        /// <summary>
        /// 第二种写法
        /// 现在在AYUI框架里，你还可以直接绑定 ICommand 这个也是可以有参数传递过来
        /// 这是MVVM框架普遍使用的方式
        /// </summary>
        public ICommand SomeCommand { get; private set; }

        /// <summary>
        /// 第三种写法，可以控制是否执行命令
        /// </summary>
        public ICommand SubmitCommand { get; private set; }

        #region 演示多个操作，同时在一个元素上的写法
        public ICommand Multy1Command { get; private set; }
        public ICommand Multy2Command { get; private set; }
        public Action<object> Multy3Action { get; private set; }
        #endregion

    }
}
