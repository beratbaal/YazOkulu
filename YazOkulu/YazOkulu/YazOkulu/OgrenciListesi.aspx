﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkulu.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>
        </tr>
          
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ID")%></td>
                        <td><%#Eval("AD")%></td>
                        <td><%#Eval("SOYAD")%></td>
                        <td><%#Eval("NUMARA")%></td>
                        <td><%#Eval("SIFRE")%></td>
                        <td><%#Eval("FOTOGRAF")%></td>
                        <td><%#Eval("BAKIYE")%></td>
                        <td><asp:HyperLink ID="HyperLink1" CssClass="btn btn-danger" runat="server" NavigateUrl='<%#"~/OgrenciSil.aspx?OGRID="+Eval("ID")%>'>Sil</asp:HyperLink>
                            <asp:HyperLink  ID="HyperLink2" CssClass="btn btn-success" runat="server" NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OGRID="+Eval("ID")%>'>Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>
</asp:Content>
