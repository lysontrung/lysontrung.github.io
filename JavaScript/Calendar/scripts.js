/* 
khoi tao du lieu
thang, so ngay trong thang,ngay trong tuan, ngay hien hanh,kiem tra ngay, kiem tra thang, kiem tra nam, vi tri ngay, ket qua 
*/
var months = new Array("January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December");
var numberDayOfMonth = new Array("31", "28", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31");
var day = new Array("Sun", "Mon", "Tue", "Web", "Thu", "Fri", "Sat");
var dateNow = new Date();
var dateCheck = new Date().getDate();
var monthCheck = new Date().getMonth();
var yearCheck = new Date().getFullYear();
var positionDayOne = 0;
var results = "";
var positionDateNow;


/*ham set ngay hien tai cho text input*/
function results() {
	results = dateCheck + "." + (monthCheck + 1) + "." + yearCheck;
	document.getElementById("output").value = results;
}
/*---------------------------------------*/

/*
ham khoi tao bang ngay, thang, nam
goi den hàm con tao cac btn, tao cac ngay trong nam, tao lich (2 tham so: thang, va nam)
*/
function init() {
	document.write("<DIV ID='calendar' STYLE='display:none;'>")
	document.write("<FORM>");
	document.write("<TABLE ID='table' STYLE='text-align: center;'>");
	this.drawRowBtn();
	this.drawDay();
	this.drawCalendar(dateNow.getMonth(), dateNow.getFullYear());
	document.write("</TABLE>");
	document.write("</FORM>");
	document.write("</DIV>")
}
/*----------------------------------------*/

/*--hàm khoi tao cac button (thang toi, thang lui, nam toi, nam lui, chon thang, chon nam) */
function drawRowBtn() {
	document.write("<TR ID='rowAction'>");
	document.write("<TD CLASS='btn' onClick='btnPreviousYearClick();'><a TYPE='a' NAME='btnPreviousYear'>&#8647;</a></TD>");
	document.write("<TD CLASS='btn' onClick='btnPreviousMonthClick();'><a TYPE='a' NAME='btnPreviousMonth'>&larr;</a></TD>");
	document.write("<TD CLASS='btn' colspan='2'><SELECT ID='months' onChange='changeMonth();'>");
	for (var i=0; i<months.length; i++) {
		document.write("<OPTION VALUE='" + i + "'>" + months[i] + "</OPTION>")
	};
	document.write("</SELECT></TD>")
	document.write("<TD CLASS='btn' colspan='1'><SELECT ID='years' onChange='changeYear();'>");
	for (var i=1900; i<=2099; i++) {
		document.write("<OPTION VALUE='" + i + "'>" + i + "</OPTION>")
	};
	document.write("</SELECT></TD>")
	document.write("<TD CLASS='btn' onClick='btnNextMonthClick();'><a TYPE='a' NAME='btnNextMonth'>&rarr;</a></TD>");
	document.write("<TD CLASS='btn' onClick='btnNextYearClick();'><a TYPE='a' NAME='btnNextYear' >&#8649;</a></TD>");
	document.write("</TR>");
}
/*---------------------------------------*/

/*-- ham khoi tao calendar | voi 2 tham so truyen vao la (thang-nam)*/
function drawCalendar(month, year) {
	var count = 1;
	for (var i=0; i<6; i++) {
		document.write("<TR onclick='closeCalendar();'>");
		for (var j=0; j<7; j++) {
			document.write("<TD ID='item" + count + "' CLASS='item' onClick='checkDay(" + count + ");'></TD>");		
			count++;		
		};
		document.write("</TR>");
	};
	setData();
	setMonths();
	setYears();
}
/*----------------------------------------------------------------------*/
	
	
/*xoa du kieu trong calendar
42 tương ứng với số ô trong lịch
*/
function erase() {
	for (var i=1; i<=42; i++) {
		document.getElementById("item" + i).innerHTML = "";
		document.getElementById("item" + i).style.background = "none";
	}
}
/*-------------------------*/

/*set data cho calendar*/
function setData() {
	var dateNow = new Date().getDate();
	var month_now = new Date().getMonth();
	var yearNow = new Date().getFullYear();
	var day = new Date(yearCheck, monthCheck, 1).getDay();
	positionDayOne = parseInt(day);
	var previous_month = monthCheck - 1;
	var next_month = monthCheck + 1;
		
	/*hàm kiểm tra năm nhuận*/
	if (((yearCheck % 4 == 0) && (yearCheck % 100 != 0)) || (yearCheck % 400 == 0)) {
		numberDayOfMonth[1] = 29; 
	} else {
		numberDayOfMonth[1] = 28;
	}
	/*-------------------*/
		
	/*--xet vi tri cua ngay thang nam trong mang bat dau tu 0*/
	if (previous_month < 0){
		previous_month = 11;
	}

	if (next_month == 12){
		next_month = 0;
	}
	/*--------------------------------------------------*/
		
	/*check ngay trong thang*/
	var numberDay = numberDayOfMonth[monthCheck];
	var numberDayOfPreviousMonth = numberDayOfMonth[previous_month];
	var numberDayOfNextMonth = numberDayOfMonth[next_month];
	/*----------------------------*/
		
	/*set vi tri hien thi cua NGAY trong calendar*/
	var position = 1;
	var count = 1;
	var check = false;
	var positionStart = day;
	var positionStop = (parseInt(numberDay) + parseInt(day));
	/*------------------------------------------*/
		
	/*mang 2chieu de hien thi ngay thang ra lich*/
	for (var i=0; i<6; i++) {
		for (var j=0; j<7; j++) {
			if (count >= day) {
				check = true;
			}
			if (check == true && position <= numberDay) {
				document.getElementById("item" + (position + day)).innerHTML = position;
				document.getElementById("item" + (position + day)).style.background = "#FBFCFC";
				if (dateNow == position && month_now == monthCheck && yearNow == yearCheck) {
					document.getElementById("item" + (position + day)).style.background = "#00ace6";
					positionDateNow = "item" + (position + day);
				}
				document.getElementById("item" + (position + day)).style.color = "#000";
				position++;
			}
			count++;
		}
	}
	
	for (var i=positionStart; i>0; i--) {
		document.getElementById("item" + (i)).innerHTML = numberDayOfPreviousMonth--;
		document.getElementById("item" + (i)).style.color = "#ffffff";
	}
	for (var j=1; j<=(42-positionStop); j++) {
		document.getElementById("item" + (j + positionStop)).innerHTML = j;
		document.getElementById("item" + (j + positionStop)).style.color = "#ffffff";
	}
}
/*--------------------------*/


/*ham kiem tra ngay trong thang*/
function checkDay(position) {
	var previous_month = monthCheck;
	var month_now = monthCheck + 1;
	var next_month = monthCheck + 2
	var year = yearCheck;
	var day = document.getElementById("item" + position).innerHTML;

	if (previous_month == 0) {
		previous_month = 12;
	}

	if (next_month == 13) {
		next_month = 1;
	}

	if (parseInt(day) > position) {
		if (previous_month == 12) {
			year--;
		}
		var results = day + "/" + previous_month + "/" + year;
	} else if (parseInt(day) < (position - positionDayOne)) {
		if (next_month == 1) {
			year++;
		}
		var results = day + "/" + next_month + "/" + year;
	} else {
		var results = day + "/" + month_now + "/" + year;
	}

	document.getElementById("output").value = results;
}
/*------------------------*/

/*kiem tra THANG va set lai data*/
function changeMonth() {
	erase();
	monthCheck = document.getElementById("months").value;
	console.log(monthCheck);
	setData();
}

function setMonths() {
	document.getElementById("months").value = monthCheck;
}
/*-------------------------------*/

/*kiem tra lai NAM va set lai data*/
function changeYear() {
	erase();
	yearCheck = document.getElementById("years").value;
	console.log(monthCheck);
	setData();
}

function setYears() {
	document.getElementById("years").value = yearCheck;
}
/*------------------*/


/*ham set event cho btn preMonth*/
	function btnPreviousMonthClick() {
		erase();
		monthCheck = monthCheck - 1;
		if (monthCheck < 0) {
			monthCheck = 11;
			yearCheck = yearCheck - 1;
		}
		console.log(monthCheck);
		setData();
		setMonths();
		setYears();
	}
/*-----------------------------*/	


/*ham set event cho btn nextMonth*/
	function btnNextMonthClick() {
		erase();
		monthCheck = monthCheck + 1;
		if (monthCheck > 11) {
			monthCheck = 0;
			yearCheck = yearCheck + 1;
		}
		console.log(monthCheck);
		setData();
		setMonths();
		setYears();
	}
/*-----------------------------------*/
	
/*ham set event cho btn preYear*/
	function btnPreviousYearClick() {
		erase();
		yearCheck = yearCheck - 1;
		console.log(monthCheck);
		setData();
		setMonths();
		setYears();
	}
/*------------------------------------*/

/*ham set event cho btn nextYear*/
	function btnNextYearClick() {
		erase();
		yearCheck = yearCheck + 1;
		console.log(monthCheck);
		setData();
		setMonths();
		setYears();
	}
/*----------------------------*/


/*khoi tao ngay trong calendar*/
	function drawDay() {
		document.write("<TR ID='title'>");
		for (var i=0; i<day.length; i++) {
			document.write("<TD>" + day[i] + "</TD>");
		};
		document.write("</TR>");
	}
/*--------------------*/

	function setItem(item, value) {
		var item = document.getElementById(item);
		item.innerHTML = value;
	}

/*đóng và mở form*/
	function closeCalendar() {
		document.getElementById("calendar").style.display = "none";
	}
	/*không cần thiết*/
	function openCalendar() {
		document.getElementById("calendar").style.display = "block";
	}
/**/