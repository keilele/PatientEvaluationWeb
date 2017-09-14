//每页的记录数
//var recordPerPage = 20;

//每个分页组的页数
//var pagePerGroup = 15;

//生成分页控件
function GetPagination(CurrentPageIndex, TotalPage, functionName, RecordCount, pagePerGroup) {

    if (CurrentPageIndex > TotalPage || CurrentPageIndex <= 0) {
        return;
    }
    else {
        var htmlContent = "";

        //每页的起始索引
        var baseIndex = parseInt((CurrentPageIndex - 1) / pagePerGroup) * pagePerGroup + 1;

        //处理当前页是第一页情况
        if (CurrentPageIndex <= pagePerGroup) {
            htmlContent = htmlContent + '<div class="row"><nav aria-label = "Page navigation" class="col-md-8"><ul class="pagination">';
            htmlContent = htmlContent + '<li class="disabled"><a  href="javascript:void(0);" >&laquo;</a></li>';
        } else {
            htmlContent = htmlContent + '<div class="row"><nav aria-label = "Page navigation" class="col-md-8"><ul class="pagination">';
            htmlContent = htmlContent + '<li><a  href="javascript:void(0);" onclick="' + functionName + '(' + (baseIndex - 1) + ') ">&laquo;</a></li>';
        }
        //加载其他页
        for (var i = baseIndex; i < baseIndex + pagePerGroup; i++) {
            if (i > TotalPage)
            { break; }

            if (i === CurrentPageIndex) {
                htmlContent = htmlContent + ' <li class="active"><a href="javascript:void(0);">' + i + '</a></li>'

            } else {

                htmlContent = htmlContent + '<li><a  href="javascript:void(0);"  onclick="' + functionName + '(' + i + ')">' + i + '</a></li>'
            }
        }
        //处理当前页是最后页情况
        if (CurrentPageIndex >= parseInt((TotalPage - 1) / pagePerGroup) * pagePerGroup + 1) {
            htmlContent = htmlContent + '<li class="disabled"><a  href="javascript:void(0);">&raquo;</a></li>';
        } else {
            htmlContent = htmlContent + '<li><a  href="javascript:void(0);" onclick="' + functionName + '(' + (baseIndex + pagePerGroup) + ')">&raquo;</a></li>';
        }
        htmlContent = htmlContent + '</ul></nav>';
        htmlContent = htmlContent + '<span class="col-md-4" style="text-align:right ;height:79px;line-height:79px;font-weight:700">';
        htmlContent = htmlContent + "查询到" + RecordCount + "条记录，共" + TotalPage + "页";
        htmlContent = htmlContent + '</span></div>'
        return htmlContent;
    }
}

//加载数据
function SetTable(obj) {

    if (obj.List.length === 0) {
        $(".pagingdiv").html('<div class="row"><span style="font-weight:bold">无数据</span></div>');
    }
    else {

        var tableStr = '<div class="row"><table id="datatable" class="table table-bordered table-hover table-condensed table-striped">';
        tableStr = tableStr + "<thead><tr>";
        for (var p in obj.List[0]) {
            tableStr = tableStr + "<th style='text-align:center;'>" + p + "</th>";
        }
        tableStr = tableStr + "</tr></thead><tbody>";
        $(obj.List).each(function (index) {
            var item = obj.List[index];

            tableStr = tableStr + "<tr>";
            for (var p in item) {
                tableStr = tableStr + "<td>";
                tableStr = tableStr + item[p];
                tableStr = tableStr + "</td>";
            }

            tableStr = tableStr + '</tr>';

        });
        tableStr = tableStr + "</tbody></table></div>";

        $(".pagingdiv").html(tableStr);
    }

}

//加载分页条
function SetPagination(CurrentPageIndex, obj, functionName, recordPerPage, pagePerGroup) {

    //得到记录数
    var RecordCount = obj.RecordCount;
    //得到总页数
    var TotalPage = Math.ceil(RecordCount / recordPerPage);
    SetTable(obj);
    //查询到数据才显示分页信息
    if (RecordCount > 0) {
        var paging = GetPagination(CurrentPageIndex, TotalPage, functionName, RecordCount, pagePerGroup);

        //显示页脚分页信息
        $(".pagingdiv").append(paging);
    }
    else {
        var pageStr = '<div class="row"><nav aria-label = "Page navigation" class="col-md-8"><ul class="pagination"></ul></nav><span class="col-md-4" style="text-align:right ;height:79px;line-height:79px;font-weight:700">';
        pageStr = pageStr + "查询到" + RecordCount + "条记录，共" + TotalPage + "页";
        pageStr = pageStr + '</span>';
        $(".pagingdiv").append(pageStr);
    }
}