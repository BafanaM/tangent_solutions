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
using Android.Util;

namespace BafanaAssessment
{
    class SlidingTab : LinearLayout
    {
        private const int DEFAULT_BOARDER_THICKNESS = 2;
        private object p;

        public SlidingTab(Context context) : this (context, null) {
        }

        public SlidingTab(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            SetWillNotDraw(false);
            float density = Resources.DisplayMetrics.Density;

            TypedValue typedValue = new TypedValue();
            context.Theme.ResolveAttribute(Android.Resource.Attribute.ColorForeground, typedValue, true);
            int themeForeGround = typedValue.Data;

        }

    }

}