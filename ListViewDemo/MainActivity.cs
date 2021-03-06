﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
    [Activity(Label = "List View Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // 
            SetContentView(Resource.Layout.Main);
            EmployeeList employeeList = new EmployeeList();
            var employees = employeeList.GetEmployees(20);
            ListView lvEmployees = FindViewById<ListView>(Resource.Id.listView1);

            EmployeeAdapter adapter = new EmployeeAdapter(employees);
            lvEmployees.Adapter = adapter;
        }
    }
}

