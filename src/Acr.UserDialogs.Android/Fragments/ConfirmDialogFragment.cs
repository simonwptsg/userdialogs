using System;
using Acr.UserDialogs.Builders;
using Android.App;
using Android.Content;
using Android.Views;


namespace Acr.UserDialogs.Fragments
{
    public class ConfirmDialogFragment : AbstractDialogFragment<ConfirmConfig>
    {
        protected override void OnKeyPress(object sender, DialogKeyEventArgs args)
        {
            base.OnKeyPress(sender, args);

            if (this.Config.IgnoreBackButton) return;

            if (args.KeyCode != Keycode.Back)
                return;

            args.Handled = true;
            this.Config?.OnAction?.Invoke(false);
            this.Dismiss();
        }


        protected override Dialog CreateDialog(ConfirmConfig config)
        {
            return new ConfirmBuilder().Build(this.Activity, config);
        }
    }


    public class ConfirmAppCompatDialogFragment : AbstractAppCompatDialogFragment<ConfirmConfig>
    {
        protected override void OnKeyPress(object sender, DialogKeyEventArgs args)
        {
            base.OnKeyPress(sender, args);

            if (this.Config.IgnoreBackButton) return;

            if (args.KeyCode != Keycode.Back)
                return;

            args.Handled = true;
            this.Config?.OnAction?.Invoke(false);
            this.Dismiss();
        }


        protected override Dialog CreateDialog(ConfirmConfig config)
        {
            return new ConfirmBuilder().Build(this.Activity, config);
        }
    }
}