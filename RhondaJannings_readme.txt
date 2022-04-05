I put together the information for roles.  I did have one issue with the one page showing Model IEnumerable Message at the top of the Role/AllRole.  Not getting any error on the build but I did need to make a change.  It could be the change in the ASP Core version we were using to to a newever version.  I will try and get that fixed.

The overall project is for a steakholder who would like our team to develop a simple website and would like the website to include the following

1) Main page that has information for the tournament: This needs to be able to be updated by the Steakholder for tournament changes year to year.
2) Gallery page that allows the steakholder to create folder to put pictures from earch tounament year.
3) Registration Login for the tournament team
4) Participant information page.  This needs to enable the ADB Employee to enter their name, email, phone and the guest name.  There on only 2 persons per team.  It is $25 per person or a total of $50 dollar per team.  Need to count each person because there are only so many spots. Additional participant information is yes/no  a) No fishing pontoon rental? and Camping space?
5) Payment Page.. Easy non expensive service etc. venmo, facebook, google and paypal.
6) Administration page to be able to see how many have signed up, Employee contact informtion, add/delete/change the Participant information or add new participants.

The only profile that is needed is for the admin. The registration should be open not waiting for role update.


Source Code:  

https://localhost:44354/

<h2>User Registration</h2>
<form method="post" action="/">
    <div class="validation-summary-valid" data-valmsg-summary="true"><ul><li style="display:none"></li>
</ul></div>
    <label for="Email">Email Address</label>
    <input type="email" data-val="true" data-val-email="The Email Address field is not a valid e-mail address." data-val-maxlength="The field Email Address must be a string or array type with a maximum length of &#x27;256&#x27;." data-val-maxlength-max="256" data-val-required="The Email Address field is required." id="Email" maxlength="256" name="Email" value="" />
    <span class="field-validation-valid" data-valmsg-for="Email" data-valmsg-replace="true"></span>
    <br />
    <label for="Password">Password</label>
    <input type="password" data-val="true" data-val-maxlength="The field Password must be a string or array type with a maximum length of &#x27;20&#x27;." data-val-maxlength-max="20" data-val-minlength="The field Password must be a string or array type with a minimum length of &#x27;6&#x27;." data-val-minlength-min="6" data-val-required="The Password field is required." id="Password" maxlength="20" name="Password" />
    <span class="field-validation-valid" data-valmsg-for="Password" data-valmsg-replace="true"></span>
    <br />
    <label for="ConfirmPassword">Confirm Password</label>
    <input type="password" data-val="true" data-val-equalto="Password does not match" data-val-equalto-other="*.Password" data-val-maxlength="The field Confirm Password must be a string or array type with a maximum length of &#x27;20&#x27;." data-val-maxlength-max="20" data-val-minlength="The field Confirm Password must be a string or array type with a minimum length of &#x27;6&#x27;." data-val-minlength-min="6" data-val-required="The Confirm Password field is required." id="ConfirmPassword" maxlength="20" name="ConfirmPassword" />
    <span class="field-validation-valid" data-valmsg-for="ConfirmPassword" data-valmsg-replace="true"></span>
    <br />
    <button type="submit">Register</button>
<input name="__RequestVerificationToken" type="hidden" value="CfDJ8ICSUouwV8pOlft_5etBKTCsvebeDhxA8bsycuEpRJ6l8GfbGuSvJi4h2z03IDcPy4WKzd2pLk7M3Ifpeqj8A0E48S4FX5V4PdWI21dnBHygSh4hnWWJw3saUyrOO3_b4flFh8agF8sxilBCuQbPGHE" /></form>
------------------------------------------------------------
https://localhost:44354/Role/AllRole

    <p><a href="/Role/AddRole">Add a role</a></p>
            <h3>All Roles</h3>
            <table border="1">
                <tr>
                    <th>Role Name</th>
                </tr>
                    <tr>
                        <td>Admin</td>
                    </tr>
                    <tr>
                        <td>Participant</td>
                    </tr>
            </table>
    <br />
    <p><a href="/Admin/Index">Back to Home</a></p>
----------------------------------------------------------------
https://localhost:44354/Role/AddRole

<h1>Add a new role</h1>
<form method="post" action="/Role/AddRole">
    <label for="Name">Name</label>
    <input type="text" id="Name" name="Name" value="" />
    <br />
    <button type="submit">Add Role</button>
<input name="__RequestVerificationToken" type="hidden" value="CfDJ8ICSUouwV8pOlft_5etBKTAr0kl0zn2GEuoiJFHebMMS53rS6jyHHkPRZm58DebmMfjl6wIKNn6YcB3etqv6ggDwLqT06T6IAfoG5FBi_AFPiO6y9INtxHQfeBpZmZ3Wd3FaR_yCT8zgJNRY1HMLea0" /></form>
<br />
<p><a href="/Admin/Index">Back to Home</a></p>
--------------------------------------------------------------
https://localhost:44354/Admin/Index
<!DOCTYPE html>
<html>
<head>

    <meta charset="utf-8" />
    <title>Administration Home</title>

</head>
<body>
    <h1>Administration Home </h1>

    <p><a href="/Role/AllRole">Show all roles</a></p>

    <p><a href="/Role/AddRole">Add a role</a></p>

    <p><a href="/Role/AddUserRole">Assign user to a role</a></p>

    <p><a href="/Admin/AllEvent">Show events</a></p>

    <p><a href="/Admin/AddEvent">Add an event</a></p>

<script src="/_framework/aspnetcore-browser-refresh.js"></script></body>
</html>
-------------------------------------------------------------------------
https://localhost:44354/Role/AddUserRole
Needs to be fixed 
NullReferenceException: Object reference not set to an instance of an object.
AspNetCore.Views_Role_AddUserRole.ExecuteAsync() in AddUserRole.cshtml
+
<p>Pick a role for @Model.User.UserName</p>

----------------------------------------------
https://localhost:44354/Admin/AllEvent
Needs fixed 
FishingTournament02.Controllers.AdminController.AllEvent() in AdminController.cs
+
            var events = db.Events.ToList();
lambda_method89(Closure , object , object[] )
--------------------------------------------------------------------

https://localhost:44354/Admin/AddEvent
p class="text-info lead">Fill out all fields</p>
<h2>Add an event</h2>
<form method="post" class="form-horizontal" action="/Admin/AddEvent">
    <label for="EventName">EventName</label>
    <input type="text" id="EventName" name="EventName" value="" />
    <br />

    <label for="EventAddress">EventAddress</label>
    <input type="text" id="EventAddress" name="EventAddress" value="" />
    <br />

    <label for="EventCity">EventCity</label>
    <input type="text" id="EventCity" name="EventCity" value="" />
    <br />

    <label for="EventState">EventState</label>
    <input type="text" id="EventState" name="EventState" value="" />
    <br />

    <label for="EventZipCode">EventZipCode</label>
    <input type="text" id="EventZipCode" name="EventZipCode" value="" />
    <br />

    <label for="EventPhone">EventPhone</label>
    <input type="text" id="EventPhone" name="EventPhone" value="" />
    <br />

    <label for="EventCapacity">EventCapacity</label>
    <input type="number" data-val="true" data-val-required="The EventCapacity field is required." id="EventCapacity" name="EventCapacity" value="" />
    <br />

    <label for="EventURL">EventURL</label>
    <input type="text" id="EventURL" name="EventURL" value="" />
    <br />

    <label for="EventCost">EventCost</label>
    <input type="text" id="EventCost" name="EventCost" value="" />
    <br />



    <button type="submit">Add Event</button>
<input name="__RequestVerificationToken" type="hidden" value="CfDJ8ICSUouwV8pOlft_5etBKTCMoweKY1oZD_X8JctWbgNyxhw9iur0hq7tEtx7S_CzM4CDSqVTxddN8oEd1AZp-WL1MghX16lQ41jLe7FyIEuvuC5xrveUmofufr4H4SAVR2519NC4R02tJHK4TeScF-o" /></form>
<br />
<p><a href="/Admin/Index">Back to Home</a></p>
--------------------------------------------------------------------

Executable
We have not built an executable

Database
Azure SQL Database 
Visual Studio
ASP.Net Core MVC C##
DB Mirgation = 20220401204634_M1