<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128553809/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3971)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Scheduler for ASP.NET MVC - How to display read-only appointments

This example demonstrates how to add the [Scheduler extension](https://docs.devexpress.com/AspNetMvc/11431/components/scheduler) to an application. The Scheduler is bound to a data source and displays read-only appointments. Refer to the following article for more information: [Lesson 1 - Use Scheduler to Display Appointments in Read-Only Mode](https://docs.devexpress.com/AspNetMvc/11554/components/scheduler/get-started/lesson-1-use-scheduler-to-display-appointments-in-read-only-mode).

<img src="https://raw.githubusercontent.com/DevExpress-Examples/scheduler-lesson-1-show-appointments-in-read-only-mode-e3971/14.2.3+/media/592dde44-debd-11e4-80bf-00155d62480c.png">

Call the Scheduler's [Bind(filterAppointmentMethod, filterResourceMethod)](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.SchedulerExtension.Bind(DevExpress.Web.Mvc.PersistentObjectCancelMethod-DevExpress.Web.Mvc.PersistentObjectCancelMethod)) method overload to hide specific appointments and resources. After that, call the [Bind(appointmentDataObject, resourceDataObject)](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.SchedulerExtension.Bind(System.Object-System.Object)) method overload to bind the extension to data.

## Files to Review

* [HomeController.cs](./CS/MVCSchedulerReadOnly/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MVCSchedulerReadOnly/Controllers/HomeController.vb))
* [SchedulerDataObject.cs](./CS/MVCSchedulerReadOnly/Models/SchedulerDataObject.cs) (VB: [SchedulerDataObject.vb](./VB/MVCSchedulerReadOnly/Models/SchedulerDataObject.vb))
* [SchedulerStorageProvider.cs](./CS/MVCSchedulerReadOnly/Models/SchedulerStorageProvider.cs) (VB: [SchedulerStorageProvider.vb](./VB/MVCSchedulerReadOnly/Models/SchedulerStorageProvider.vb))
* [Index.cshtml](./CS/MVCSchedulerReadOnly/Views/Home/Index.cshtml)
* [SchedulerPartial.cshtml](./CS/MVCSchedulerReadOnly/Views/Home/SchedulerPartial.cshtml)

## Documentation

* [Lesson 1 - Display Read-Only Appointments in Scheduler](https://docs.devexpress.com/AspNetMvc/11554/components/scheduler/get-started/lesson-1-use-scheduler-to-display-appointments-in-read-only-mode)
* [Lesson 2 - Edit Data in Scheduler](https://docs.devexpress.com/AspNetMvc/11567/components/scheduler/get-started/lesson-2-implement-the-insert-update-delete-appointment-functionality)
* [Lesson 3 - Use Scheduler in Complex Views](https://docs.devexpress.com/AspNetMvc/11629/components/scheduler/get-started/lesson-3-use-scheduler-in-complex-views)

## More Examples

* [Scheduler for ASP.NET MVC - How to allow users to edit data](https://github.com/DevExpress-Examples/scheduler-lesson-2-insert-update-delete-appointment-feature-e3984)
