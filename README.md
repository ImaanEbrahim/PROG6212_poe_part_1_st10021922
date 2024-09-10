# PROG6212_poe_part_1_st10021922
LectraClaim - Contract Monthly Claim System
Overview
LectraClaim is a WPF (Windows Presentation Foundation) application designed for Independent Contractor (IC) lecturers to submit monthly claims, upload supporting documents, and track the status of their claims. It also provides a platform for Programme Coordinators and Academic Managers to verify and approve claims efficiently.

This application is currently a front-end prototype for demonstration purposes, with no functional back-end implementation yet.

Getting Started
Prerequisites
To run this application, you will need:

A Windows machine
.NET Core SDK installed (version 3.1 or higher)
Visual Studio (with WPF and .NET development tools enabled)
Steps to Run the Application
Clone the Repository
First, clone the LectraClaim project from GitHub to your local machine:

bash
Copy code
git clone https://github.com/ImaanEbrahim/PROG6212_poe_part_1_st10021922.git
Open the Project in Visual Studio

Launch Visual Studio.
Open the cloned solution (LectraClaim.sln).
Build the Project

In Visual Studio, click on Build from the top menu and select Build Solution. Ensure that there are no build errors.
Run the Application

Once the project is built, run the application by clicking the Start button in Visual Studio or pressing F5.
How to Use LectraClaim
Main Window (Dashboard)
Upon launching the application, you will be greeted with the main dashboard, offering options for various user roles. The UI is designed to be intuitive and easy to navigate.

Lecturer Functionalities
Submit a New Claim

Navigate to the "Submit Claim" section.
Enter your details, hours worked, and other relevant claim information.
Click Submit Claim to record your entry (Note: This is a prototype, and no actual data is submitted at this stage).
Upload Supporting Documents

In the claim submission window, click on the Upload Document button.
Select the file(s) to upload for supporting your claim.
Track Claim Status

After submitting a claim, you can view its status in the Track Claims section.
Claim statuses (Pending, Approved, or Rejected) are displayed for easy reference.
Coordinator/Manager Functionalities
Verify and Approve Claims

Programme Coordinators and Academic Managers can navigate to the Verify Claims section.
View all submitted claims, with options to review supporting documents.
Click Approve or Reject for each claim (currently, this action is only visually represented in the prototype).
View and Filter Claims

Coordinators and Managers can filter claims by status (Pending, Approved, Rejected).
Use the search feature to quickly find specific lecturer claims.
Features (Prototype Only)
User-friendly UI for submitting and tracking claims.
Uploading documents (UI representation only, no actual file handling).
Transparent claim status tracking for lecturers.
Visual buttons and forms for coordinators and managers to approve/reject claims.
Known Limitations
The system is currently a prototype. No back-end or database integration is implemented.
The UI is static; claim data is not stored or processed.
Only front-end actions are available for now.
Future Enhancements
Implement full back-end functionality for claim submission and approval.
Add database integration for storing and managing claims.
Enhance security with role-based access control (RBAC).
Improve UI for better responsiveness and performance.
License
This project is licensed under the MIT License - see the LICENSE file for details.
