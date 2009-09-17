/**
 * Version: 1.4.0
 * Build Date: 27-Aug-2008
 * Copyright (c) 2006-2008, Coolite Inc. (http://www.coolite.com/). All rights reserved.
 * Website: http://www.coolite.com/
 */
Coolite.FreeDatePicker=function(config){if(!config||config===null){return null;}
var defaults={dateFormat:"d-MMM-yyyy",eastImage:"/aspnet_client/basicframe_webcontrols_basicdatepicker/1_4_0/arrow_right.gif",westImage:"/aspnet_client/basicframe_webcontrols_basicdatepicker/1_4_0/arrow_left.gif",enabled:true,maximumDate:"9999/12/31",minimumDate:null,nullDate:null,xOffset:0,yOffset:-2,styles:{popUp:"",calendar:"",noneButton:"",todayButton:"",title:"",nextPrev:"",dayHeader:"",day:"",otherMonthDay:"",weekendDay:"",selectedDay:"",todayDay:"",otherMonthDayWeekendDay:"",selectedDayTodayDay:"",selectedDayWeekendDay:"",todayDayWeekendDay:""},cssClasses:{popUp:"bdplPopUp",calendar:"bdplCalendar",noneButton:"bdplClearButton",todayButton:"bdplTodayButton",title:"bdplTitle",nextPrev:"bdplNextPrev",dayHeader:"bdplDayHeader",day:"bdplDay",otherMonthDay:"bdplDay bdplOtherMonthDay",weekendDay:"bdplDay bdplWeekendDay",selectedDay:"bdplDay bdplSelectedDay",todayDay:"bdplDay bdplTodayDay",otherMonthDayWeekendDay:"bdplDay bdplOtherMonthDay bdplWeekendDay ",selectedDayTodayDay:"bdplDay bdplTodayDay bdplSelectedDay",selectedDayWeekendDay:"bdplDay bdplWeekendDay bdplSelectedDay",todayDayWeekendDay:"bdplDay bdplWeekendDay bdplTodayDay"}};for(var p in defaults){this[p]=defaults[p];if(p=="events"||p=="styles"||p=="cssClasses"){for(var p2 in defaults[p]){this[p][p2]=defaults[p][p2];}}}
for(var c in config){this[c]=config[c];if(c=="events"||c=="styles"||c=="cssClasses"){for(var c2 in config[c]){this[c][c2]=config[c][c2];}}}
this.visibleDate=null;this.maximumDate=Date.parseExact(this.maximumDate,"yyyy/M/d");this.minimumDate=Date.parseExact(this.minimumDate,"yyyy/M/d");this.input=null;this.button=null;this.calendar=null;this.yearInc=null;this.timeout=null;this.interval=null;this._isDate=false;this._isApplied=false;this.calendarShim=null;this.generatedHTML=null;this.isOpen=false;this.applyTo=function(config){if(!config||config===null){return null;}
if(config.inputID){this.input=Coolite.Dom.get(config.inputID);Coolite.Event.addListener(this.input,'keydown',this._inputKeyDown,this);Coolite.Event.addListener(this.input,'focus',this._inputFocus,this,true);Coolite.Event.addListener(this.input,'blur',this._inputBlur,this,true);Coolite.Event.addListener(this.input,'click',this._inputClick,this,true);}
if(config.buttonID){this.button=Coolite.Dom.get(config.buttonID);Coolite.Event.addListener(this.button,'click',this._buttonClick,this,true);}
this._isApplied=true;$COOL.controls.push({type:"FreeDatePicker",control:this});return this;};this.setVisibleDate=function(date){this.visibleDate=(date!==null)?date.clone().clearTime().moveToFirstDayOfMonth():Date.today().moveToFirstDayOfMonth();return this;};this.getVisibleDate=function(){if(this.visibleDate===null){this.visibleDate=Date.today().moveToFirstDayOfMonth();}
return this.visibleDate;};this.show=function(){if(this.isOpen){return this;}
Coolite.Event.removeListener(this.input,'blur',this._inputBlur);Coolite.Event.addListener(document,'click',this._documentClick,this,true);Coolite.Event.addListener(document,'keypress',this._documentKeyPress,this,true);var d=null;if(this.getIsDate()){d=this.getSelectedDate();this.setSelectedDate(d);this.setVisibleDate(d);}
if(!this.calendar){this.calendar=document.createElement("DIV");this.calendar.id=this.clientID+"_calendar";this.calendar.style.position="absolute";this.calendar.style.visibility="hidden";this.calendar.style.zIndex="100002";Coolite.Event.addListener(this.calendar,'click',this._calendarClick,this,true);Coolite.Event.addListener(this.calendar,'mousewheel',this._scroll,this,true);Coolite.Event.on(this.calendar,"DOMMouseScroll",this._scroll,this,true);document.body.appendChild(this.calendar);}
this.render(d,this.getVisibleDate());this.calendar.style.visibility="visible";this.isOpen=true;return this;};this.close=function(){if(!this.isOpen){return this;}
Coolite.Event.addListener(this.input,'blur',this._inputBlur,this,true);Coolite.Event.removeListener(document,'click',this._documentClick);Coolite.Event.removeListener(document,'keypress',this._documentKeyPress);if(this.calendar){this.calendar.style.visibility="hidden";}
$COOL.hideShim(this.calendarShim);this.isOpen=false;return this;};this.render=function(selectedDate,visibleDate){this.setVisibleDate(visibleDate||Date.today());var count=0,o=this._renderMonth(visibleDate,selectedDate,true,true);this.generatedHTML=o;this.calendar.innerHTML=o;var els=Coolite.Dom.getElementsByClassName("bdpDayItem","a",this.calendar);for(i=0;i<els.length;i++){Coolite.Event.addListener(els[i],'click',this._dayClick,this);}
var p=Coolite.Dom.getXY(this.button),popupMaxTop=p[1]-this.calendar.offsetHeight,windowHeight;if($COOL.isIEWin){popupMaxTop-=1;}
var popupMaxBottom=this.yOffset+p[1]+this.button.offsetHeight+this.calendar.offsetHeight;if(window.innerHeight){windowHeight=Math.max(window.innerHeight,document.documentElement.clientHeight);}else{windowHeight=(document.documentElement.clientHeight>0)?document.documentElement.clientHeight:document.body.clientHeight;}
windowHeight=windowHeight+Math.max(document.documentElement.scrollTop,document.body.scrollTop);this.calendar.style.left=(this.xOffset+p[0]+this.button.offsetWidth-this.calendar.offsetWidth)+"px";this.calendar.style.top=((popupMaxBottom>windowHeight&&popupMaxTop>0)?popupMaxTop:(this.yOffset+p[1]+this.button.offsetHeight))+"px";if(parseInt(this.calendar.style.left,10)<0){this.calendar.style.left=0;}
if(parseInt(this.calendar.style.top,10)<0){this.calendar.style.top=0;}
this.calendarShim=$COOL.makeShim(this.calendarShim,this.calendar);return this;};this._dayClick=function(e,el){el.setSelectedDate(new Date(parseInt(this.getAttribute("d"),0))).close().focus();};this._renderMonth=function(date,selectedDate,showPrevMonthArrow,showNextMonthArrow){var nvd=date.clone().addMonths(1),pvd=date.clone().addMonths(-1),o=[];o.push('<table border="0" cellpadding="0" cellspacing="0"',$COOL.buildStyleAttributes(this.styles.popUp,this.cssClasses.popUp),'><tr><td>');o.push('<table border="0" cellpadding="0" cellspacing="0"',$COOL.buildStyleAttributes(this.styles.title,this.cssClasses.title),'><tr>');o.push('<td onclick="',this.clientID,'.showPrevMonth()"',$COOL.buildStyleAttributes(this.styles.nextPrev,this.cssClasses.nextPrev),'><img src="',this.westImage,'" alt="" /></td>');o.push('<th>',date.toString("MMMM yyyy"),'</th>');o.push('<td onclick="',this.clientID,'.showNextMonth()"',$COOL.buildStyleAttributes(this.styles.nextPrev,this.cssClasses.nextPrev),'><img src="',this.eastImage,'" alt="" /></td></tr></table>');o.push('<table border="0" cellpadding="0" cellspacing="0"',$COOL.buildStyleAttributes(this.styles.calendar,this.cssClasses.calendar),'><thead><tr>');var dayPointer=Date.CultureInfo.firstDayOfWeek;for(var j=0;j<7;j++,dayPointer++){if(dayPointer==7){dayPointer=0;}
o.push('<th',$COOL.buildStyleAttributes(this.styles.dayHeader,this.cssClasses.dayHeader),' title="',Date.CultureInfo.dayNames[dayPointer],'">');o.push(Date.CultureInfo.firstLetterDayNames[dayPointer],"</th>");}
o.push("</tr></thead><tbody><tr>");var caret=date.clone().moveToFirstDayOfMonth();var startingPos=caret.getDay()-Date.CultureInfo.firstDayOfWeek;if(startingPos<Date.CultureInfo.firstDayOfWeek){startingPos+=7;}
var month,prev=caret.clone().addDays(-1).getMonth(),next=caret.clone().addMonths(1).getMonth(),lastDayOfWeek;caret.add(startingPos*-1).days();for(d=1;d<=42;d++){month=caret.getMonth();lastDayOfWeek=((d%7)===0);if(month===prev){o.push(this._renderDay(caret,selectedDate,"prev"));}else if(month===next){o.push(this._renderDay(caret,selectedDate,"next"));}else{o.push(this._renderDay(caret,selectedDate,"current"));}
caret.addDays(1);if(lastDayOfWeek){o.push("</tr><tr>");}}
o.push("</tr></tbody></table></td></tr></table>");return o.join('');};this._renderDay=function(date,selectedDate,type){var o=[],dayClassName="",isToday=Date.equals(Date.today(),date.clearTime()),isWeekday=(!date.is().sat&&!date.is().sun()),styleToUse=null,styleCssClassToUse=null,isSelectedDay=(selectedDate===null)?false:date.equals(selectedDate);switch(type){case"current":if(isSelectedDay&&isToday){if(isWeekday){styleToUse=this.styles.selectedDayTodayDay;styleCssClassToUse=this.cssClasses.selectedDayTodayDay;}else{styleToUse=this.styles.selectedDayWeekendDay;styleCssClassToUse=this.cssClasses.selectedDayWeekendDay;}}else if(isSelectedDay){if(isWeekday){styleToUse=this.styles.selectedDay;styleCssClassToUse=this.cssClasses.selectedDay;}else{styleToUse=this.styles.selectedDayWeekendDay;styleCssClassToUse=this.cssClasses.selectedDayWeekendDay;}}else if(isToday){if(isWeekday){styleToUse=this.styles.todayDay;styleCssClassToUse=this.cssClasses.todayDay;}else{styleToUse=this.styles.todayDayWeekendDay;styleCssClassToUse=this.cssClasses.todayDayWeekendDay;}}else{if(isWeekday){styleToUse=this.styles.day;styleCssClassToUse=this.cssClasses.day;}else{styleToUse=this.styles.weekendDay;styleCssClassToUse=this.cssClasses.weekendDay;}}
break;case"prev":case"next":if(isWeekday){styleToUse=this.styles.otherMonthDay;styleCssClassToUse=this.cssClasses.otherMonthDay;}else{styleToUse=this.styles.otherMonthDayWeekendDay;styleCssClassToUse=this.cssClasses.otherMonthDayWeekendDay;}
break;}
o.push("<td",$COOL.buildStyleAttributes(styleToUse,styleCssClassToUse),' title="',date.toString(this.dateFormat),'">');if(type=="current"||type=="prev"||type=="next"){o.push('<a onclick="return false;" d="',date.getTime(),'" class="bdpDayItem" href="#">',date.getDate(),'</a>');}else{o.push("&nbsp;");}
o.push("</td>");return o.join('');};this.clear=function(){this.setSelectedDate(null);return this;};this.getText=function(){return $COOL.getInputValue(this.input);};this.getMaximumDate=function(){return(this.maximumDate!==null)?this.maximumDate:new Date(9999,11,1);};this.setMaximumDate=function(date){this.maximumDate=date;return this;};this.getMinimumDate=function(){return(this.minimumDate!==null)?this.minimumDate:new Date(1,0,1);};this.setMinimumDate=function(date){this.minimumDate=date;return this;};this.setVisibleDate=function(date){this.visibleDate=(date!==null)?date.clone().clearTime().moveToFirstDayOfMonth():Date.today().moveToFirstDayOfMonth();return this;};this.getVisibleDate=function(){if(this.visibleDate===null){this.visibleDate=Date.today().moveToFirstDayOfMonth();}
return this.visibleDate;};this.showNextMonth=function(){this.showMonth(this.getVisibleDate().addMonths(1));return this;};this.showPrevMonth=function(){this.showMonth(this.getVisibleDate().addMonths(-1));return this;};this.showMonth=function(date){this.render(this.getSelectedDate(),date);return this;};this.setSelectedDate=function(date){var s="",d=(date||null);var text=this.getText();if(d===null||d==this.nullDate||d===0){this.setVisibleDate(null);s="";}else if(d instanceof Date){s=d.toString(this.dateFormat);}
if(text!=s){$COOL.setInputValue(this.input,s);}
if(this.isOpen&&d!==null){this.render(d,d.clone().moveToFirstDayOfMonth());}
return this;};this.getSelectedDate=function(){var date=Date.parseExact(this.getText(),this.dateFormat);if(date===null){date=Date.parse(this.getText());}
this._isDate=((!$COOL.isNullOrEmpty(this.getText())&&date!==null)||($COOL.isNullOrEmpty(this.getText())&&date===null));return date;};this.getSelectedDateFormatted=function(){return(this.getIsNull())?"":this.getSelectedDate().toString(this.dateFormat);};this.getIsDate=function(){this.getSelectedDate();return this._isDate;};this.getIsNull=function(){return(this.getSelectedDate()===null);};this.focus=function(){this.input.focus();return this;};};Coolite.FreeDatePicker.prototype._buttonClick=function(e,el){Coolite.Event.stopEvent(e);el.toggle();};Coolite.FreeDatePicker.prototype._inputFocus=function(e,el){Coolite.Event.stopEvent(e);el.close();};Coolite.FreeDatePicker.prototype._inputClick=function(e,el){Coolite.Event.stopEvent(e);el.close();};Coolite.FreeDatePicker.prototype.toggle=function(){if(this.isOpen){this.close();}else{this.show();}
return this;};Coolite.FreeDatePicker.prototype._inputBlur=function(ev,el){if(el.getText()!==el.inputFocusValue&&el.getIsDate()){el.setSelectedDate(el.getSelectedDate());}
el.close();};Coolite.FreeDatePicker.prototype._inputKeyDown=function(ev,el){var c=Coolite.Event.getCharCode(ev);var s=$COOL.getPositionStart(el.input);if(c==8||c==9){Coolite.FreeDatePicker.closeAll();return;}};Coolite.FreeDatePicker.prototype._documentKeyPress=function(e,el){if(!e){e=winodow.event;}
if(e.keyCode==9||e.keyCode==13){Coolite.FreeDatePicker.closeAll();}};Coolite.FreeDatePicker.prototype._documentClick=function(e,el){if(el.getText()!==el.inputFocusValue){el.setSelectedDate(el.getSelectedDate());}
el.close();};Coolite.FreeDatePicker.prototype._calendarClick=function(e){Coolite.Event.stopEvent(e);};Coolite.FreeDatePicker.closeAll=function(){for(var i=0;i<$COOL.controls.length;i++){if($COOL.controls[i].type=="FreeDatePicker"){$COOL.controls[i].control.close();}}};Coolite.FreeDatePicker.showAll=function(){for(var i=0;i<$COOL.controls.length;i++){if($COOL.controls[i].type=="FreeDatePicker"){$COOL.controls[i].control.show();}}};
if(typeof Sys!=="undefined"){Sys.Application.notifyScriptLoaded();}
