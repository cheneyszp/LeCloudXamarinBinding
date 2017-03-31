using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Lecloud.Xutils.Task;
using Com.Letv.Pano.Vrlib.Strategy;
using Java.Lang;
using Object = Java.Lang.Object;

namespace Com.Lecloud.Xutils.Task
{
    public partial class PriorityObjectBlockingQueue
    {

        public partial class Itr : global::Java.Util.IIterator
        {
            public Object Next()
            {
                return null;
            }
        }
    }
}

namespace Com.Letv.Pano.Vrlib.Strategy.Display
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.letv.pano.vrlib.strategy.display']/class[@name='DisplayModeManager']"
    public partial class InteractiveModeManager: ModeManager
    {
        protected override Java.Lang.Object CreateStrategy(int p0)
        {
            return null;
        }

        protected override int[] GetModes()
        {
            return new int[0];
        }

        public InteractiveModeManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public InteractiveModeManager(int p0) : base(p0)
        {
        }
    }
}


namespace Com.Letv.Pano.Vrlib.Strategy.Interactive
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.letv.pano.vrlib.strategy.interactive']/class[@name='InteractiveModeManager']"
    public partial class InteractiveModeManager
    {
        protected override Object CreateStrategy(int p0)
        {
            throw new NotImplementedException();
        }
    }
}


namespace Com.Lecloud.Xutils.Http
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.lecloud.xutils.http']/class[@name='HttpHandler']"
    public partial class HttpHandler: PriorityAsyncTask
    {
        //protected override Java.Lang.Object DoInBackground(params Object[] p0)
        //{
        //    return null;
        //}
    }

}


namespace Com.Letv.Pano.Vrlib.Strategy.Display
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.letv.pano.vrlib.strategy.display']/class[@name='DisplayModeManager']"
    public partial class DisplayModeManager: Com.Letv.Pano.Vrlib.Strategy.ModeManager
    {
        //protected override Java.Lang.Object CreateStrategy(int p0)
        //{
        //    throw new NotImplementedException();
        //}

    }
}


namespace Com.Lecloud.Sdk.Listener
{
	[global::Android.Runtime.Register ("com/lecloud/sdk/listener/EventArgs", DoNotGenerateAcw=true)]
    public partial class JEventArgs : global::System.EventArgs
    {

        //public EventArgs(int p0, global::Android.OS.Bundle p1)
        //{
        //    this.p0 = p0;
        //    this.p1 = p1;
        //}

        //int p0;
        //public int P0
        //{
        //    get { return p0; }
        //}

        //global::Android.OS.Bundle p1;
        //public global::Android.OS.Bundle P1
        //{
        //    get { return p1; }
        //}
    }
}
