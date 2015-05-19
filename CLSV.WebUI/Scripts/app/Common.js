
function LoadControl(type) {
    switch (type)
    {
        case 'pos' :
            $("#page-inner").load('/Partial/_Pos');
            break;
        case 'home':
            $("#page-inner").load('/Home/_Home');
            break;
        case 'chart':
            $("#page-inner").load('/Partial/_ChartLayout');
            break;
        case 'salesorder':
            $("#page-inner").load('/Partial/_SalesOrder');
            break;            

    }   

}

function highlight(str, term) {
    var highlight_regex = new RegExp('(' + term + ')', 'gi');
    return str.replace(highlight_regex,
      '<span class="highlight">$1</span>');
};

function ShowLoadingEffect() {
    alert("m blocking");
    $.blockUI({
        message: '<h1><img src="/Images/appimages/loading.gif" /> </h1>',
        css: {
            top: (($(window).height()) / 2 - 51) + 'px',
            left: (($(window).width()) / 2 - 64) + 'px',
            width: '1px',
            height: '1px',
            border: 'none',
            padding: '0px',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            //opacity: 0.9,
            color: '#fff'

        }, overlayCSS: { backgroundColor: '#000', opacity: 0.8 }
    });
}

function BlockAlertBox(message, heading) {
    heading = heading || "Alert";
    var msg = "<div class='boxheading'>" + heading + "</div> " +
        "<div class='boxmessage'>" + message + "</div>";

    $.blockUI({
        message:
            "<div class='boxContainer'>" +
            "<div class='boxcontainer1'>" + msg + "</div>" +
            "<div class='boxcontainer2'><input class='boxclosebtn' id='mclose' type='button' value='Close' /></div>" +
            "</div>",
        css: {
            border: '0px',
            left: '0px',
            width: $(window).width(),
            height: $(window).height() / 4
        }
    });
    $('#mclose').click($.unblockUI);
    $('.blockOverlay').attr('title', 'Click here to unblock').click($.unblockUI);
}

function ConvertChartObjectToLine(data)
{
    var arr = new Array(data.length);
    for (var key in data)
    {
        var innerArr = new Array();
        innerArr.push(data[key]["X"]);
        innerArr.push(data[key]["Y"]);
        arr[key]=innerArr;
    }
    return arr;
}
