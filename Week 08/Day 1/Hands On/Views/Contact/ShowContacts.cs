using System.Reflection;

@model IEnumerable<DataAccessLayer.Models.ContactInfo>

<a asp-action= "AddContact" > Add Contact</a>

<table class= "table table-bordered" >
    < tr >
        < th > Name </ th >
        < th > Email </ th >
        < th > Company </ th >
        < th > Department </ th >
    </ tr >

@foreach(var item in Model)
{
    < tr >
        < td > @item.FirstName @item.LastName </ td >
        < td > @item.EmailId </ td >
        < td > @item.CompanyName </ td >
        < td > @item.DepartmentName </ td >
    </ tr >
}
</ table >