﻿$(document).ready(function () {
    $("#btnAdd").click(function () {
        alert("mauahahaha");
        //var maLoai = $("#listMaLoai").find("option:selected").text();
        //var soLuong = $("#txtSoLuong").val();
        //var tenLoai = $("#listMaLoai").find("option:selected").val();

        //var row = '<tr>                                                                   '
        //      + '  <td>                                                                 '
        //      + '      <input type="hidden"  value="' + tenLoai + '" />                        '
        //      + '  </td>                                                                '
        //      + '  <td>                                                                 '
        //      + '      <input type="hidden" name="soLuong[]" value="' + soLuong + '" />       '
        //      + '  </td>                                                                '
        //      + '  <td>                                                                 '
        //      + '      <input type="hidden" name="maLoai[]" value="' + maLoai + '" />        '
        //      + '  </td>                                                                '
        //      + ' </tr>;                                                                '
        //$("#table_createChiTietPhieuNhap").append(row);
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