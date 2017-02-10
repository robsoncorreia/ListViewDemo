using Android.Views;
using ListViewDemo.Resources.layout;

namespace ListViewDemo
{
    public interface IEmployeeAdapter
    {
        Employee this[int position] { get; }

        int Count { get; }

        long GetItemId(int position);
        View GetView(int position, View convertView, ViewGroup parent);
    }
}