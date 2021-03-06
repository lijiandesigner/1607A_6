﻿
/*执行文件上传(第一个参数为上传控件,第二个参数为上传的一般处理程序的路径),第三个参数为要跳转的路径*/
function uploadFile(obj, handlerPath, autoJumpPath) {

    var formData = new FormData();
    var name = obj.val();
    formData.append("file", obj[0].files[0]);
    formData.append("name", name);
    $.ajax({
        url: handlerPath,
        type: 'POST',
        data: formData,
        // 告诉jQuery不要去处理发送的数据
        processData: false,
        // 告诉jQuery不要去设置Content-Type请求头
        contentType: false,
        beforeSend: function () {
            console.log("正在进行，请稍候");
        },
        success: function (responseStr) {
            if (autoJumpPath != undefined && autoJumpPath != "") {
                location.href = autoJumpPath;
            }
        },
        error: function (responseStr) {
            console.log("error");
        }
    });
}
//获取上传的路径(第一个参数为上传的文件夹的名称,第二个参数为上传控件的jquery对象)
function getLuJing(folderName, uploadControl) {
    /*此处省略验证部分的代码*/
    var head = "/" + folderName + "/" + uploadControl.val();
    var index = head.lastIndexOf('\\');
    head = "/" + folderName + "/" + head.substr(index + 1);
    return head;
}

//从地址URL中获取到参数id
function getIdByUrl() {
    var index = location.search.indexOf("=");

    return location.search.substring(index + 1);
}
