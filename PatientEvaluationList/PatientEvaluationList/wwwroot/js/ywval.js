//统一验证方法
function validateMessage() {
    var result = true;
    //统一验证必填
    $(".ywval-req").each(function () {
        if ($(this).val() === "") {
            addVal($(this), $(this).attr("placeholder") + '不能为空');
            throw false;
        }
    });

    //验证手机
    $(".ywval-tel").each(function () {
        if (!(/^1(3|4|5|7|8)\d{9}$|^$/.test($(this).val()))) {
            addVal($(this), $(this).attr("placeholder") + '手机格式不正确')
            throw "exception";
        }
        else {
            result = true;
        }
    });

    //验证邮箱
    $(".ywval-email").each(function () {
        if (!(/^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$|^$/.test($(this).val()))) {
            addVal($(this), $(this).attr("placeholder") + '邮箱格式不正确')
            throw "exception";
        }
        else {
            result = true;
        }
    });
    //验证生日(短时间)
    $(".ywval-shortbirthday").each(function () {
        var now = new Date();
        var birthday = new Date($(this).val());
        var millonSecond = (150 * 365 + 60) * 24 * 60 * 60 * 1000;
        if (!(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$|^$/.test($(this).val()))) {
            addVal($(this), $(this).attr("placeholder") + '请输入正确的时间格式（yyyy-mm-dd）')
            throw "exception";
        } else
            if (birthday.getTime() > now.getTime()) {
                addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
                throw "exception";
            } else
                if ((now.getTime() - birthday.getTime()) > millonSecond) {
                    addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
                    throw "exception";
                } else {
                    result = true;
                }
    });

    //验证生日(长时间)
    $(".ywval-longbirthday").each(function () {
        var now = new Date();
        var birthday = new Date($(this).val());
        var millonSecond = (150 * 365 + 60) * 24 * 60 * 60 * 1000;
        if (!(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2}) (\d{1,2}):(\d{1,2}):(\d{1,2})$|^$/.test($(this).val()))) {
            addVal($(this), $(this).attr("placeholder") + '请输入正确的时间格式（yyyy-mm-dd）')
            throw "exception";
        } else
            if (birthday.getTime() > now.getTime()) {
                addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
                throw "exception";
            } else
                if ((now.getTime() - birthday.getTime()) > millonSecond) {
                    addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
                    throw "exception";
                } else {
                    result = true;
                }
    });
    //验证年龄(输入的是数字)
    $(".ywval-age").each(function () {
        if (!(/^\d+$|^$/.test($(this).val()))) {
            addVal($(this), $(this).attr("placeholder") + '您输入的不是一个正确的数字')
            throw "exception";
        } else
            if (parseInt($(this).val()) < 0 || parseInt($(this).val()) > 150) {
                addVal($(this), $(this).attr("placeholder") + '年龄范围不合法');
                throw "exception";
            } else {
                result = true;
            }
    });

    //验证固定电话
    $(".ywval-fixtel").each(function () {
        if (!(/^(([0\+]\d{2,3}-)?(0\d{2,3})-)(\d{7,8})(-(\d{3,}))?$|^$/.test($(this).val()))) {
            addVal($(this), $(this).attr("placeholder") + '输入正确的固话格式（xxxx-xxxxxxxx）')
            throw "exception";
        } else {
            result = true;
        }
    });

    //验证时间格式
    $(".ywval-date").each(function () {
        var now = new Date();
        var birthday = new Date($(this).val());
        if (!(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$|^$/.test($(this).val()))) {
            addVal($(this), $(this).attr("placeholder") + '请输入正确的时间格式（yyyy-mm-dd）')
            throw "exception";
        } else
            if (birthday.getTime() > now.getTime()) {
                addVal($(this), $(this).attr("placeholder") + '日期范围不正确')
                throw "exception";
            } else {
            result = true;
        }
    });

    //验证身份证号
    $(".ywval-idnumber").each(function () {
        if (!(/(^\d{15}$)|(^\d{18}$)|(^\d{17}(\d|X|x)$)|^$/.test($(this).val()))) {
            addVal($(this), $(this).attr("placeholder") + '请输入正确的身份证号（15位或18位）')
            throw "exception";
        }
        else {
            result = true;
        }
    });

    return result;
}
//移除验证提示标签
function removeVal(obj) {
    var left = obj.offset().left + obj.width() + 20;
    var top = obj.offset().top + obj.height() / 2 - 9;
    var id = "#ID" + top.toString().replace('.', '') + left.toString().replace('.', '')
    $(id).remove();
}
//添加验证提示标签
function addVal(obj, content) {
    var fleft = $(obj).parent().offset().left;
    var ftop = $(obj).parent().offset().top;
    var left = obj.offset().left + obj.width() + 20;
    var top = obj.offset().top + obj.height() / 2 - 9;
    var id = "ID" + top.toString().replace('.', '') + left.toString().replace('.', '');
    //判断标签是否存在
    if (!document.getElementById(id)) {
        var divhtml = '<div id="' + id + '" class="tip" data-content="&#x25c0;" style="top:' + (top - ftop) + 'px;left:' + (left - fleft) + 'px;">' + content + '</div >';
      
        $(obj).parent().append(divhtml);
        //$("body").append(divhtml);
    }
    return id;
}
//必填字段验证
function valReq() {
    if ($(this).val() === '') {
        addVal($(this), $(this).attr("placeholder") + '不能为空')
        throw "exception";
    }
    else {
        removeVal($(this));
    }
}
//验证手机
function valTel() {
    if (!(/^1(3|4|5|7|8)\d{9}$|^$/.test($(this).val()))) {
        addVal($(this), $(this).attr("placeholder") + '手机格式不正确')
        throw "exception";
    }
    else {
        removeVal($(this));

    }
}
//验证邮箱地址
function valEmail() {
    if (!(/^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$|^$/.test($(this).val()))) {
        addVal($(this), $(this).attr("placeholder") + '邮箱格式不正确')
        throw "exception";
    }
    else {
        removeVal($(this));
    }
}
//验证生日(短时间)
function valShortBirthday() {
    var now = new Date();
    var birthday = new Date($(this).val());
    var millonSecond = (150 * 365 + 60) * 24 * 60 * 60 * 1000;
    if (!(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$|^$/.test($(this).val()))) {
        addVal($(this), $(this).attr("placeholder") + '请输入正确的时间格式（yyyy-mm-dd）')
        throw "exception";
    } else
        if (birthday.getTime() > now.getTime()) {
            addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
            throw "exception";
        } else
            if ((now.getTime() - birthday.getTime()) > millonSecond) {
                addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
                throw "exception";
            } else {
                removeVal($(this));
            }
}
//验证生日（长时间）
function valLongBirthday() {
    var now = new Date();
    var birthday = new Date($(this).val());
    var millonSecond = (150 * 365 + 60) * 24 * 60 * 60 * 1000;
    if (!(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2}) (\d{1,2}):(\d{1,2}):(\d{1,2})$|^$/.test($(this).val()))) {
        addVal($(this), $(this).attr("placeholder") + '请输入正确的时间格式（yyyy-mm-dd HH:mm:ss）')
        throw "exception";
    } else
        if (birthday.getTime() > now.getTime()) {
            addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
            throw "exception";
        } else
            if ((now.getTime() - birthday.getTime()) > millonSecond) {
                addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
                throw "exception";
            } else {
                removeVal($(this));
            }
}
//验证年龄（通过数字验证）
function valAge() {
    if (!(/^\d+$|^$/.test($(this).val()))) {
        addVal($(this), $(this).attr("placeholder") + '您输入的不是一个正确的数字')
        throw "exception";
    } else
        if (parseInt($(this).val()) < 0 || parseInt($(this).val()) > 150) {
            addVal($(this), $(this).attr("placeholder") + '年龄范围不合法');
            throw "exception";
        } else {
            removeVal($(this));
        }
}
//验证固定电话
function valFixTel() {
    if (!(/^(([0\+]\d{2,3}-)?(0\d{2,3})-)(\d{7,8})(-(\d{3,}))?$|^$/.test($(this).val()))) {
        addVal($(this), $(this).attr("placeholder") + '格式不正确(例：0041-89480000)')
        throw "exception";
    } else {
        removeVal($(this));
    }
}
//验证时间格式
function valDate() {
    var now = new Date();
    var birthday = new Date($(this).val());
    var millonSecond = (150 * 365 + 60) * 24 * 60 * 60 * 1000;
    if (!(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$|^$/.test($(this).val()))) {
        addVal($(this), $(this).attr("placeholder") + '请输入正确的时间格式（yyyy-mm-dd）')
        throw "exception";
    } else
        if (birthday.getTime() > now.getTime()) {
            addVal($(this), $(this).attr("placeholder") + '出生日期范围不正确')
            throw "exception";
        }else {
        removeVal($(this));
    }
}

//验证身份证号
function valIDnumber() {
    if (!(/^(\d{6})(\d{4})(\d{2})(\d{2})(\d{3})([0-9]|X)$|^$/.test($(this).val()))) {
        addVal($(this), $(this).attr("placeholder") + '请输入正确的身份证号（15位或18位）')
        throw "exception";
    }
    else {
        removeVal($(this));
    }
}
//绑定集点失去事件到验证类上
$(function () {
    $(".ywval-req").bind('blur', valReq);
    $(".ywval-tel").bind('blur', valTel);
    $(".ywval-email").bind('blur', valEmail);
    $(".ywval-shortbirthday").bind('blur', valShortBirthday);
    $(".ywval-longbirthday").bind('blur', valLongBirthday);
    $(".ywval-age").bind('blur', valAge);
    $(".ywval-fixtel").bind('blur', valFixTel);
    $(".ywval-date").bind('blur', valDate);
    $(".ywval-idnumber").bind('blur', valIDnumber);
})
