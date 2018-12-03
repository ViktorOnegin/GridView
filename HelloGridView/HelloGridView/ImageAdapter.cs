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

namespace HelloGridView
{
    class ImageAdapter : BaseAdapter
    {
        Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public override int Count
        {
            get { return thumbIds.Length; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if(convertView == null)
            {
                imageView = new ImageView(context);
                imageView.LayoutParameters = new GridView.LayoutParams(85, 85);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(8, 8, 8, 8);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(thumbIds[position]);
            return imageView;
        }

        int[] thumbIds =
        {
            Resource.Drawable.sample_2, Resource.Drawable.sample_3,
            Resource.Drawable.sample_4, Resource.Drawable.sample_5,
            Resource.Drawable.sample_6, Resource.Drawable.sample_7,
            Resource.Drawable.sample_0, Resource.Drawable.sample_1,
            Resource.Drawable.sample_2, Resource.Drawable.sample_3,
            Resource.Drawable.sample_4, Resource.Drawable.sample_5,
            Resource.Drawable.sample_6, Resource.Drawable.sample_7,
            Resource.Drawable.sample_0, Resource.Drawable.sample_1,
            Resource.Drawable.sample_2, Resource.Drawable.sample_3,
            Resource.Drawable.sample_4, Resource.Drawable.sample_5,
            Resource.Drawable.sample_6, Resource.Drawable.sample_7
        };
    }
}