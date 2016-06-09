<%@ Page Title="Students" Language="C#" MasterPageFile="~/Interior.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="MasciApps_Week5.Students" %>

<asp:Content ID="StudentsPageContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="students-page">
        <div class="container">

            <div class="button button1"><a href="StudentDetails.aspx"><i class="fa fa-plus-circle"></i> Add Student</a></div>
            <div class="students-container">
                <asp:GridView runat="server" ID="StudentsGridView" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="StudentID" HeaderText="Student ID" Visible="true" />                
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" Visible="true" />
                        <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />
                        <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" Visible="true" 
                            DataFormatString="{0:MMM dd, yyyy}" />
                    </Columns>
                </asp:GridView>
            </div>

        </div>  
    </div>

</asp:Content>
