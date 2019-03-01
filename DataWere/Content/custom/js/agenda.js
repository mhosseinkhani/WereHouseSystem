var date = new Date();
var d = date.getDate(),
    m = date.getMonth(),
    y = date.getFullYear();
var stDate = $('calendar').fullCalendar('getView').start;
var endDate = $('calendar').fullCalendar('getView').end;

/********************************************************************************

*                   MULTIOPERATORE AGENDA

********************************************************************************/

$('#agenda').fullCalendar('refetchEvents');
$('#agenda').fullCalendar({
    header: {
        left: 'prev,next today',
        center: 'title',
        right: 'month,agendaWeek,agendaDay,listDay'
    },
    defaultView: 'agendaWeek',
    editable: true,
    allDaySlot: false,
    selectable: true,
    timezone: 'local',
    minTime: '07:00',
    maxTime: '24:00',
    slotDuration: '00:15:00',
    axisFormat: 'HH:mm',
    timeFormat: 'HH:mm',
    contentHeight: 'auto',
    nowIndicator: true,
    eventStartEditable: true,
    googleCalendarApiKey: 'AIzaSyB0G5lQrKKbwY8SwpraKdxTIJuQaPiySE8',
    eventSources: [
         
        
    ],
    eventConstraint: {
        start: moment().format('YYYY-MM-DD'),
        end: '2100-01-01' // hard coded goodness unfortunately
    },
    eventDragStop: function (event, jsEvent, ui, view) {

    },
    eventClick: function (calEvent, jsEvent, view) {

    },
    slotLabelFormat: "HH:mm",
    eventDrop: function (event, delta, revertFunc, jsEvent, ui, view) {
        
    },
    dayClick: function (date, jsEvent, view) {
    },
    select: function (start, end) {
        
    },
    selectable: true,
    editable: false,
    droppable: false,
    navLinks: true,
    eventRender: function (event, element) {  
    }
});