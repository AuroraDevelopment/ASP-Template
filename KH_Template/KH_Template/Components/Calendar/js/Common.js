var manyColor;


var SmallCalendar = function (datePickerClass, calendarListClass) {

    currentCalendarObject = this;
    this.datePickerClass = datePickerClass;
    this.calendarListClass = calendarListClass;
    this.today = new Date();
    this.currDate = new Date();
    this.liHtml;
    this.calliHtml;
    this.itemURL;
    this.eventDuration;
    this.date;
    this.currentDate = null;
    this.currWeekDate = null;
    this.datetext;
    this.calendarDate;
    this.L_Menu_BaseUrl = "";
    //this.siteRelUrl = L_Menu_BaseUrl;
    this.currentTime;
    this.hours;
    this.minutes;
    this.lastday;
    this.isNextMnth;
    this.camlFields;
    this.camlQuery;
    this.camlOptions;
    this.formattedTime;
    this.i;
    //var url = document.URL;
    // var index = url.indexOf("/en/");

    /*    if (index == -1) //arabic
    {
    this.pickerOpts = {
    monthNames: ['يناير', 'فبراير', 'مارس', 'ابريل', 'مايو', 'يونيو', 'يوليو', 'أغسطس', 'سبتمبر', 'أكتوبر', 'نوفمبر', 'ديسمبر'],
    monthNamesShort: ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12'],
    dayNames: ['الأحد', 'الاثنين', 'الثلاثاء', 'الأربعاء', 'الخميس', 'الجمعة', 'السبت'],
    dayNamesShort: ['أحد', 'اثنين', 'ثلاثاء', 'أربعاء', 'خميس', 'جمعة', 'سبت'],
    dayNamesMin: ['ح', 'ا', 'ث', 'ا', 'خ', 'ج', 'س'],
    dateFormat: 'dd/mm/yyyy',
    firstDay: 0,
    prevText: '&#x3c;', prevStatus: '',
    prevJumpText: '&#x3c;&#x3c;', prevJumpStatus: '',
    nextText: '&#x3e;', nextStatus: '',
    nextJumpText: '&#x3e;&#x3e;', nextJumpStatus: '',
    currentText: 'اليوم', currentStatus: '',
    todayText: 'اليوم', todayStatus: '',
    clearText: '-', clearStatus: '',
    closeText: 'إغلاق', closeStatus: '',
    yearStatus: '', monthStatus: '',
    weekText: 'أسبوع', weekStatus: '',
    defaultStatus: '',
    isRTL: true,
    onSelect: function (dateText, inst) { $(this).datepicker('setDate', ''); },
    onChangeMonthYear: function (year, month, date) {
    fillCalendar(year, month, date, false)
    }
    };
    }
    else //english
    {*/
    var pickerOpts = {
        monthNames: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],
        monthNamesShort: ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12'],
        dayNames: ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'],
        dayNamesShort: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
        dayNamesMin: ['S', 'M', 'T', 'W', 'T', 'F', 'S'],
        changeMonth: false,
        hideIfNoPrevNext: false,
        navigationAsDateFormat: true,
        //selectOtherMonths: true,
        //showOtherMonths: true,
        dateFormat: 'dd/mm/yyyy',
        firstDay: 0,
        prevText: '&#x3c;',
        prevStatus: '',
        prevJumpText: '&#x3c;&#x3c;', prevJumpStatus: '',
        nextText: '&#x3e;', nextStatus: '',
        nextJumpText: '&#x3e;&#x3e;', nextJumpStatus: '',
        currentText: 'Today', currentStatus: '',
        todayText: 'Today', todayStatus: '',
        clearText: '-', clearStatus: '',
        closeText: 'Close', closeStatus: '',
        yearStatus: '', monthStatus: '',
        weekText: 'Week', weekStatus: '',
        defaultStatus: '',
        onSelect: function (dateText, inst) { $(this).datepicker('setDate', ''); },
        onChangeMonthYear: function (year, month, date) {
            fillCalendar(year, month, date, false)
        }
    };
    $(".divDatePicker").datepicker(pickerOpts);
    $(".divDatePicker").datepicker('option', { onSelect: 'disabled' });
    fillCalendar(2013, 1, 1, false);
    //$("a.ui-datepicker-event").addClass('eventholder');
    //$(".ui-datepicker-header").append('<a class="icon-settings" style="width:36px;height:33px;"></a>');

}

fillCalendar = function (year, month, date, isNextMnth) {
    //var pageUrl = 'http://10.2.3.141:8002/en/_layouts/15/LinkDev.KM.ASRT.Portal/EventsService.asmx/GetEventsList'; 
    var clndata = '../../Components/calendar/GetCalendarData.aspx'
    $.ajax({
        url: clndata,
        type: 'POST',
        dataType: 'xml',
        // Disable caching of AJAX responses
        cache: false,
        success: function (data, textStatus, xhr) {
            processResult1(data, textStatus);
        },
        error: function (xhr, textStatus, errorThrown) {
            //$('#' + id + ' .contentarea').html(textStatus);
        }
    });



    processResult1 = function (data, status) {
        currentCalendarObject.lastday = new Date();
        currentCalendarObject.i = 7 - (currentCalendarObject.currDate.getDay() + 1);
        currentCalendarObject.lastday.setDate(currentCalendarObject.lastday.getDate() + currentCalendarObject.i);
        manyColor = $(data).find("ManyColorItem").attr("Many_Color")
        $(data).find("EventItem").each(function () {
            var $entry = $(this);
            many = $entry.attr("ows_Many");
            currentCalendarObject.date = new Date($entry.attr("ows_EventDate").substring(0, 4), $entry.attr("ows_EventDate").substring(5, 7) - 1,
                $entry.attr("ows_EventDate").substring(8, 10), $entry.attr("ows_EventDate").substring(11, 13), $entry.attr("ows_EventDate").substring(14, 16),
                $entry.attr("ows_EventDate").substring(17, 19));
            //if (date.getDate() >= today.getDate() && date.getMonth() == today.getMonth()) {
            if (true) {
                //var itemURL = currentCalendarObject.siteRelUrl.replace("/res","");
                //currentCalendarObject.itemURL = itemURL+ "/res/events/" + $entry.attr("ows_ID");


                if ($entry.attr("ows_fAllDayEvent") == '1') {
                    currentCalendarObject.eventDuration = "(All day event)";
                }
                else {
                    currentCalendarObject.eventDuration = '(' + currentCalendarObject.getFormattedTime($entry.attr("ows_EventDate")) + ' - ' + currentCalendarObject.getFormattedTime($entry.attr("ows_EndDate")) + ')';
                }
                $('.ui-datepicker-calendar a')
                    .filter(function (index) {
                        var $entry1 = $(this);
                        var b = $entry1.text() == currentCalendarObject.date.getDate() &&
                                    $entry1.parent('td').attr("data-year") == currentCalendarObject.date.getFullYear() &&
                                    $entry1.parent('td').attr("data-month") == currentCalendarObject.date.getMonth() ||
                                    $entry1.text() >= $entry.attr("ows_EventDate").substring(8, 10) &&
                                    $entry1.text() <= $entry.attr("ows_EndDate").substring(8, 10) &&
                                    $entry1.parent('td').attr("data-year") == $entry.attr("ows_EventDate").substring(0, 4) &&
                                    $entry1.parent('td').attr("data-month") == $entry.attr("ows_EventDate").substring(5, 7) - 1;


                        return b;
                    }).addClass("ui-datepicker-event").addClass("ui-state-active").attr("style", "background-color:" + $entry.attr("ows_EventCategory"));



                var divpopupid = "#" + currentCalendarObject.date.getDate() + "_eventPopUp";


                if ($('.ui-datepicker-calendar a.ui-datepicker-event').next(divpopupid).length == 0)
                    CreatePopUp($entry.attr("ows_EventDate"), $entry.attr("ows_EndDate"), currentCalendarObject.itemURL, $entry.attr("ows_Title"), $entry.attr("ows_EventCategory"));
                else
                    CreatePopUpItem($entry.attr("ows_EventDate"), $entry.attr("ows_EndDate"), currentCalendarObject.itemURL, $entry.attr("ows_Title"), $entry.attr("ows_EventCategory"));




                currentCalendarObject.currentDate = currentCalendarObject.date;
            }

            if (currentCalendarObject.date.setHours(0, 0, 0, 0) >= currentCalendarObject.today.setHours(0, 0, 0, 0) && currentCalendarObject.date.getMonth() >= currentCalendarObject.today.getMonth() &&
                currentCalendarObject.date.setHours(0, 0, 0, 0) <= currentCalendarObject.lastday.setHours(0, 0, 0, 0)) {

                currentCalendarObject.currWeekDate = currentCalendarObject.date;

            }

        });
        //$(".ui-datepicker-week-end").attr("class","");
        //$(".divCalendarList").html("");
        $(".divCalendarUL").each(function () {
            if ($(this).children(".divCalendarLI").length > 1) {
                $(this).parent().parent().parent().children("a:first").attr("style", "border-color:" + manyColor);
            }
        });

    }
    SmallCalendar.prototype.getFormattedTime = function (eventDate) {
        currentCalendarObject.currentTime = new Date(eventDate.substring(0, 4), eventDate.substring(5, 7) - 1, eventDate.substring(8, 10), eventDate.substring(11, 13),
            eventDate.substring(14, 16), eventDate.substring(17, 19));
        currentCalendarObject.hours = currentCalendarObject.currentTime.getHours();
        currentCalendarObject.minutes = currentCalendarObject.currentTime.getMinutes();
        if (currentCalendarObject.minutes < 10) {
            currentCalendarObject.minutes = "0" + currentCalendarObject.minutes;
        }
        if (currentCalendarObject.hours > 11) {
            if (currentCalendarObject.hours > 12) {
                return (currentCalendarObject.hours - 12) + ":" + currentCalendarObject.minutes + " " + "PM";
            }
            else {
                return currentCalendarObject.hours + ":" + currentCalendarObject.minutes + " " + "PM";
            }
        }
        else {
            return currentCalendarObject.hours + ":" + currentCalendarObject.minutes + " " + "AM";
        }
    }

    CreatePopUp = function (eventDate, eventDuration, itemURL, title, color) {
	
        $('#current .ui-datepicker-calendar a.ui-datepicker-event').filter(function (index) {
            // alert($(this).text() +"  " +currentCalendarObject.date.getDate())
            return $(this).text() == currentCalendarObject.date.getDate();
            /* $(this).parent('td').attr("data-year") == currentCalendarObject.date.getFullYear() &&
            $(this).parent('td').attr("data-month") == currentCalendarObject.date.getMonth()||
            $(this).text() >= eventDate.substring(8, 10) &&
            $(this).text() <= eventDuration.substring(8, 10) ;*/
        }).parent('td').append("<div class='eventPopUpDiv' id='" + currentCalendarObject.date.getDate() + "_eventPopUp' style='display:none'><div id='" + currentCalendarObject.date.getDate() + "_eventPopUpInner' class='eventPopUpDivbg'></div></div> ");


        $('#current .ui-datepicker-calendar a').filter(function (index) {
            return $(this).text() == currentCalendarObject.date.getDate(); /* &&
                        $(this).parent('td').attr("data-year") == currentCalendarObject.date.getFullYear() &&
                        $(this).parent('td').attr("data-month") == currentCalendarObject.date.getMonth()||
                                    $(this).text() >= eventDate.substring(8, 10) &&
                                    $(this).text() <= eventDuration.substring(8, 10) ;*/

        }).parent('td').mouseover(function () {
            document.getElementById($(this).find('a').first().text() + "_eventPopUp").style.display = "inline";
        });

        $('#current .ui-datepicker-calendar a')
           .filter(function (index) {
               return $(this).text() == currentCalendarObject.date.getDate(); /* &&
                        $(this).parent('td').attr("data-year") == currentCalendarObject.date.getFullYear() &&
                        $(this).parent('td').attr("data-month") == currentCalendarObject.date.getMonth() ||
                                    $(this).text() >= eventDate.substring(8, 10) &&
                                    $(this).text() <= eventDuration.substring(8, 10);*/
           }).parent('td').mouseout(function () {
               document.getElementById($(this).find('a').first().text() + "_eventPopUp").style.display = "none";
           });



           $("#current #" + currentCalendarObject.date.getDate() + "_eventPopUpInner").append("<div class = 'divCalendarUL '>");
        CreatePopUpItem(eventDate, eventDuration, itemURL, title, color);

        $("#current #" + currentCalendarObject.date.getDate() + "_eventPopUpInner").append("</div><div class='ClearH'></div>");
    }


    CreatePopUpItem = function (eventDate, eventDuration, itemURL, title, color) {
        /*  var SD = new Date(eventDate.substring(0, 4),eventDate.substring(5, 7) - 1, eventDate.substring(8, 10), eventDate.substring(11, 13),
        eventDate.substring(14, 16), eventDate.substring(17, 19));
        eventDate= SD.format("dd mmm yyyy HH:mm");

        var ED = new Date(eventDuration.substring(0, 4),eventDuration.substring(5, 7) - 1, eventDuration.substring(8, 10), eventDuration.substring(11, 13),
        eventDuration.substring(14, 16), eventDuration.substring(17, 19));
        eventDuration= ED.format("dd mmm yyyy HH:mm");*/

        //eventDuration= eventDuration.toString("dd mmm yyyy");   	 

        currentCalendarObject.calliHtml = '<div class="divCalendarLI" ><h3 class="calHead"><a class="anchCalLi" style="color:' + color + '"' + 'href="' + itemURL + '">' + title + '</a></h3 ><div class="events-dates">  From: <span>' + eventDate + '</span></div><div class="events-dates"> To: <span>' + eventDuration + '</span></div></div>';

        $("#current #" + currentCalendarObject.date.getDate() + "_eventPopUpInner" + " .divCalendarUL").append(currentCalendarObject.calliHtml);

    }

}
