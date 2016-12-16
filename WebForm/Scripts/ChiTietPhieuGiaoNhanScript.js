$(document).ready(function () {
    $.ajax({
        url: '/PhieuGiaoNhan/SelectLoai/',
        type: 'Get',
        dataType: 'json',
        success: function (listLoai) {
            var rows = '';
            alert(listLoai);
            $.each(listLoai, function (i, item) {
                rows += '<option>' + item.tenLoai + '</option>';
                $("#dropDown_selectLoai").append(rows);
            });
            alert(rows);
        }
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