<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MVCSchedulerReadOnly/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MVCSchedulerReadOnly/Controllers/HomeController.vb))
* [SchedulerDataObject.cs](./CS/MVCSchedulerReadOnly/Models/SchedulerDataObject.cs) (VB: [SchedulerDataObject.vb](./VB/MVCSchedulerReadOnly/Models/SchedulerDataObject.vb))
* [SchedulerStorageProvider.cs](./CS/MVCSchedulerReadOnly/Models/SchedulerStorageProvider.cs) (VB: [SchedulerStorageProvider.vb](./VB/MVCSchedulerReadOnly/Models/SchedulerStorageProvider.vb))
* [Index.cshtml](./CS/MVCSchedulerReadOnly/Views/Home/Index.cshtml)
* [SchedulerPartial.cshtml](./CS/MVCSchedulerReadOnly/Views/Home/SchedulerPartial.cshtml)
<!-- default file list end -->
# Scheduler - Lesson 1 - Show appointments in read-only mode


<p>This example demonstrates how to show appointments in a simple scheduling application using <strong>MVC Scheduling Extensions</strong> bound to data. We suggest that you review it if you are a first-time user of the<strong> ASP .NET MVC Scheduler</strong>.<br /> Note that the scheduler is in read-only mode to make the code easier to understand.<br /> This project is created by following the step-by-step guide of the <a href="http://documentation.devexpress.com/#AspNet/CustomDocument11554"><u>Lesson 1 - Use Scheduler to Display Appointments in Read-Only Mode</u></a>.<br /> To learn how to implement the appointment editing functionality, review step-by-step guide in the <a href="http://documentation.devexpress.com/#AspNet/CustomDocument11567"><u>Lesson 2 - Implement Insert-Update-Delete Appointment Functionality</u></a> and see the result in the <a href="https://www.devexpress.com/Support/Center/p/E3984">E3984: Scheduler - Lesson 2 - Insert-Update-Delete appointment feature</a> example.</p>
<p>The <strong>SchedulerExtension.Bind</strong> method overload allows to hide specific appointments and resources. In this example it is used to hide appointments with "Test" in their subject lines and resources containing "TEST" in their captions. Note that the final data binding, i.e. a call to the <strong>SchedulerExtension.Bind(object appointmentDataObject, object resourceDataObject) </strong>should be placed <strong>after</strong> the call to the Bind method overload which filters appointments.<br /><br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/scheduler-lesson-1-show-appointments-in-read-only-mode-e3971/14.2.3+/media/592dde44-debd-11e4-80bf-00155d62480c.png"></p>

<br/>


