# How to intergrate Syncfusion WinForms Control in VSTO excel Add-in project

To integrate Syncfusion WinForms Control for VSTO Excel add-ins by following these below steps :

 Here is an example for integrating the SfDatagrid in VSTO Excel add-ins.

Step 1: Start Visual Studio.

Step 2: Create a VSTO Excel Add-in project.

 
 ![Adding_ExcelVSTO_image.png](https://support.syncfusion.com/kb/agent/attachment/article/15364/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE4NzY2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.z0tBQHtnLHa5LEYybYjWZKq30FcXF7RKFziLlKsYXJs)

Step 3: Include a Form in VSTO Excel Add-in project and load the SfDataGrid control.

 
 ![IncludeFormImage.png](https://support.syncfusion.com/kb/agent/attachment/article/15364/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE4NzY0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.CBeNxU_8IHW-DKwXH3pPr4IdbkOkjVkThrg6TsoHrK8)


Step 4: In the ThisAddIn class, within the ThisAddIn_Startup event of your VSTO Excel Add-in, use the form.Show() method to display the Form.

 
 ```C#
   private void ThisAddIn_Startup(object sender, System.EventArgs e)
   {
      Form1 form = new Form1();
      form.Show();
   }

 ```

 
 ![AddIns_Image.png](https://support.syncfusion.com/kb/agent/attachment/article/15364/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE4NzY1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.khTVBCgqLfr5ROvT4Ip1YR_Aek-FB_YXN4NhiWwuoWQ)

Step 5: Run the application; you will see Excel with Syncfusion controls, as shown in the image below:


**Output Image Reference:**

 
 ![Output_Image.png](https://support.syncfusion.com/kb/agent/attachment/article/15364/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE4NzI5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.RizsywO0bwd_ND1HmprFNHw8_8aKR_O74FU7dHS7RgI)

Take a moment to peruse the [https://help.syncfusion.com/windowsforms/datagrid/overview](WPF-DataGrid -Localization)WPF-DataGrid- documentation, to learn more about DataGrid examples.

