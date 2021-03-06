﻿<%@ Page Language="C#" AutoEventWireup="true" Title="Filter by annual check up page" MasterPageFile="~/Site.Master" CodeBehind="FilterByAnnualCheckUp.aspx.cs" Inherits="CarsSystem.WebForms.Client.Filters.FilterByAnnualCheckUp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h1 class="text-center">All cars which annual check up expires soon!</h1>
            <asp:GridView ID="FilterGridView" runat="server" AutoGenerateColumns="false" CssClass="text-center table table-striped table-hover">
                <Columns>
                    <asp:BoundField DataField="Manufacturer" HeaderText="Manufacturer" />
                    <asp:BoundField DataField="Model" HeaderText="Model" />
                    <asp:BoundField DataField="RegistrationNumber" HeaderText="Registration number" />
                    <asp:BoundField DataField="VINNumber" HeaderText="VIN number" />
                    <asp:BoundField DataField="ValidUntilAnnualCheckUp" HeaderText="Valid until" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <br />
    <br />
    <div class="row">
        <div class="col-md-12 col-md-offset-2">
            <div class="col-md-1 text-right">
                <asp:Label ID="EmailSubjectLabel" runat="server" Text="Subject: " CssClass="control-label"></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:TextBox ID="EmailSubjectTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-1 text-right">
                <asp:Label ID="EmailContentLabel" runat="server" Text="Content:" CssClass="control-label"></asp:Label>
            </div>
            <div class="col-md-2">
                <asp:TextBox ID="EmailContentBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Button ID="SendMailButton" runat="server" Text="Send e-mails to the filtered cars!" OnClick="SendMailButton_Click" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
