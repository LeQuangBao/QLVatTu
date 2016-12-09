$(document).ready(function () {
    $("#btnAdd").click(function () {

        //$("#table_createChiTietPhieuNhap").find("tr:last-child").not("thead tr").append('<tr> <td> <select class="form-control col-md-4" name="maLoai[0]" id=""> @foreach(Model.Loai l in listLoai) { <option value="@l.MaLoai">@l.TenLoai</option> } </select> </td> <td> <input type="text" class="form-control" name="soLuong[0]" /> </td> </tr>)');
        $("#table_createChiTietPhieuNhap").append('<tr> <td> <select class="form-control col-md-4" name="maLoai[0]" id=""> @foreach(Model.Loai l in listLoai) { <option value="@l.MaLoai">@l.TenLoai</option> } </select> </td> <td> <input type="text" class="form-control" name="soLuong[0]" /> </td> </tr>)');
    });
});
/*
<tr>
    <td id="row_Addbuton" colspan="2">
        <button type="button" class="btn btn-success btn-md" id="btnAdd">+</button>
    </td>
</tr>
<tr> <td> <select class="form-control col-md-4" name="maLoai[0]" id=""> @foreach(Model.Loai l in listLoai) { <option value="@l.MaLoai">@l.TenLoai</option> } </select> </td> <td> <input type="text" class="form-control" name="soLuong[0]" /> </td> </tr>
*/