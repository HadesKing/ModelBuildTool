
//显示错误信息
function ShowErrorMessage(message) {
    layer.alert(message, { icon: 2, title: "错误" });
}
//显示成功信息
function ShowSuccessMessage(message) {
    layer.alert(message, { icon: 1, title: "信息" });
}

/**
 * 发送http请求
 * @param {any} method
 * @param {any} url
 * @param {any} dataType 
 * @param {any} data : 发送数据
 * @param {any} callback : 回调函数，有一个参数记录操作返回结果
 */
/*
 * dataType: 告诉服务器，我要想什么类型的数据，除了常见的json、XML，还可以指定 html、jsonp、script或者text
 * 
 * 可用值:
 * 1、"xml": 返回 XML 文档，可用 jQuery 处理。
 * 
 * 2、"html": 返回纯文本 HTML 信息；包含的 script 标签会在插入 dom 时执行。
 
 * 3、"script": 返回纯文本 JavaScript 代码。不会自动缓存结果。除非设置了 "cache" 参数。注意：在远程请求时(不在同一个域下)，所有 POST 请求都将转为 GET 请求。（因为将使用 DOM 的 script标签来加载）
 * 
 * 4、"json": 返回 JSON 数据 。
 
 * 5、"jsonp": JSONP 格式。使用 JSONP 形式调用函数时，如 "myurl?callback=?" jQuery 将自动替换 ? 为正确的函数名，以执行回调函数。
 * 
 * 6、"text": 返回纯文本字符串
 *
 * 7、"local":返回本地数据（即第一次初始化时只加载本地代码显示的样式，而不加载任何后台返回的数据）
 * 
 * contentType: 发送信息至服务器时内容编码类型，简单说告诉服务器请求类型的数据
 * 
  * */

function SendHttpRequest(method, url, dataType, data, callback) {
    $.ajax({
        url: url
        , type: method
        , async: true
        , cache: true
        , contentType: "application/json" //默认值是application/x-www-form-urlencoded
        , dataType: dataType
        , data: data
        , error: function (XMLHttpRequest, textStatus, errorThrown) {
            var errorMessage = "Operation failed.Server return http status is " + XMLHttpRequest.status;
            ShowErrorMessage(errorMessage);
        }
        , success: function (result) {
            layer.msg('Success');
            callback(result);
        }
    });

}


