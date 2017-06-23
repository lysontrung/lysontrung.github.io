/* 
khoi tao du lieu
thang, so ngay trong thang,ngay trong tuan, ngay hien hanh,kiem tra ngay, kiem tra thang, kiem tra nam, vi tri ngay, ket qua 
*/
var months = new Array("January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December");
var numberDayOfMonth = new Array("31", "28", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31");
var day = new Array("Sun", "Mon", "Tue", "Web", "Thu", "Fri", "Sat");
var dateNow = new Date();
var dateCheck = new Date().getdate();
var monthCheck = new Date().getMonth();
var yearCheck = new Date().getFullYear();
var positionDayOne = 0;
var results = "";
var positionDateNow;

/*
ham set ngay hien tai cho text input
*/
function setResult() {
	results = dateCheck + "/" + (monthCheck + 1) + "/" + yearCheck;
	document.getElementByid("output").values = results;
	console.log(results);
}

/*
ham khoi tao bang ngay, thang, nam
goi den hàm con tao cac btn, tao cac ngay trong nam, tao lich (2 tham so: thang, va nam)
*/
function init() {
	document.write("<div id='calendar' style='display:none;'>")
		document.write("<form>");
			document.write("<table id='table' style='text-align: center;'>");
			this.drawBtns();
			this.drawDay();
			this.drawCalendar(dateNow.getMonth(), dateNow.getFullYear());
			document.write("</table>");
		document.write("</form>");
	document.write("</div>")
}

/*--hàm khoi tao cac button (thang toi, thang lui, nam toi, nam lui, chon thang, chon nam) */
	function drawBtns() {
		document.write("<tr id='btns'>");
		document.write("<td class='btn' onclick='btnPrevYear();'><a type='a' name='btnPreviousYear'>&#8647;</a></td>");
		document.write("<td class='btn' onclick='btnPrevMonth();'><a type='a' name='btnPreviousMonth'>&larr;</a></td>");
		document.write("<td class='btn' colspan='2'><select id='months' onchange='selectMonth();'>");
		for (var i = 0; i < months.length; i++) {
			document.write("<option values='" + i + "'>" + months[i] + "</option>")
		};
		document.write("</select></td>")
		document.write("<td class='btn' colspan='1'><select id='years' onChange='selectYear();'>");
		for (var i = 1900; i <= 2025; i++) {
			document.write("<option values='" + i + "'>" + i + "</option>")
		};
		document.write("</select></td>")
		document.write("<td class='btn' onClick='btnNextMonth();'><a type='a' name='btnNextMonth'>&rarr;</a></td>");
		document.write("<td class='btn' onClick='btnNextYear();'><a type='a' name='btnNextYear' >&#8649;</a></td>");
		document.write("</TR>");
	}
/*--*/

/*ham khoi tao cac ngay trong calendar*/
function drawDay() {
		document.write("<TR id='title'>");
		for (var i = 0; i < day.length; i++) {
			document.write("<td>" + day[i] + "</td>");
		};
		document.write("</TR>");
	}
/*--*/
	
/*-- ham khoi tao calendar | voi 2 tham so truyen vao la (thang-nam)*/
	function drawCalendar(month, year) {
		var count = 1;
		for (var i = 0; i < 6; i++) {
			document.write("<TR onclick='closeCalendar();'>");
			for (var j = 0; j < 7; j++) {
				document.write("<td id='item" + count + "' class='item' onClick='checkDay(" + count + ");'></td>");		
				count++;		
			};
			document.write("</TR>");
		};
		setdata();
		setMonths();
		setYears();
	}
/*--*/

/*xoa du kieu trong calendar*/
	function erase() {
		for (var i = 1; i <= 42; i++) {
			document.getElementByid("item" + i).innerHTML = "";
			document.getElementByid("item" + i).style.background = "none";
		}
	}

/*set data cho calendar*/
	function setdata() {
		var dateNow = new Date().getdate();
		var monthNow = new Date().getMonth();
		var yearNow = new Date().getFullYear();
		var day = new Date(yearCheck, monthCheck, 1).getday();
		// get vi trí hien tai cua ngay
		positionDayOne = parseInt(day);
		var previous_month = monthCheck - 1;
		var monthNext = monthCheck + 1;
		
		// kiem tra co phai nam nhuan hay khong de tra ve so ngay phu hop
		if (((yearCheck % 4 == 0) && (yearCheck % 100 != 0)) || (yearCheck % 400 == 0)) {
			numberDayOfMonth[1] = 29; 
		} else {
			numberDayOfMonth[1] = 28;
		}
		
		/*--xet vi tri cua ngay thang nam trong mang bat dau tu 0*/
		if (previous_month < 0){
			previous_month = 11;
		}
		if (monthNext == 12){
			monthNext = 0;
		}
		/*--*/
		
		/*check ngay trong thang*/
		var numberDay = numberDayOfMonth[monthCheck];
		var numberDayOfPreviousMonth = numberDayOfMonth[previous_month];
		var numberDayOfNextMonth = numberDayOfMonth[monthNext];
		/*--*/
		
		/*set vi tri hien thi cua NGAY trong calendar*/
		var position = 1;
		var count = 1;
		var check = false;
		var positionStart = day;
		var positionStop = (parseInt(numberDay) + parseInt(day));
		/*--*/

		/*mang 2 chieu set vitri ngay trong calendar*/
		for (var i = 0; i < 6; i++) {
			for (var j = 0; j < 7; j++) {
				if (count >= day) {
					check = true;
				}
				if (check == true && position <= numberDay) {
					document.getElementByid("item" + (position + day)).innerHTML = position;
					document.getElementByid("item" + (position + day)).style.background = "#FBFCFC";
					if (dateNow == position && monthNow == monthCheck && yearNow == yearCheck) {
						document.getElementByid("item" + (position + day)).style.background = "#00ace6";
						positionDateNow = "item" + (position + day);
					}
					document.getElementByid("item" + (position + day)).style.color = "#000";
					position++;
				}
				count++;
			}
		}
		/*42 la so o hien thi ngay*/
		for (var i = positionStart; i>0; i--) {
			document.getElementByid("item" + (i)).innerHTML = numberDayOfPreviousMonth--;
			document.getElementByid("item" + (i)).style.color = "#ffffff";
		}
		for (var j=1; j <= (42 - positionStop); j++) {
			document.getElementByid("item" + (j + positionStop)).innerHTML = j;
			document.getElementByid("item" + (j + positionStop)).style.color = "#ffffff";
		}
	}
/*--*/
	
/*ham kiem tra ngay trong thang*/
	function checkDay(position) {
		var previous_month = monthCheck;
		var monthNow = monthCheck + 1;
		var monthNext = monthCheck + 2
		var year = yearCheck;
		var day = document.getElementByid("item" + position).innerHTML;

		/*set vi tri cua THANG theo thu tu co trong mang*/
		if (previous_month == 0) {
			previous_month = 12;
		}

		if (monthNext == 13) {
			monthNext = 1;
		}
		/*--*/
		
		if (parseInt(day) > position) {
			if (previous_month == 12) {
				year--;
			}
			var results = day + "/" + previous_month + "/" + year;
		} else if (parseInt(day) < (position - positionDayOne)) {
			if (monthNext == 1) {
				year++;
			}
			var results = day + "/" + monthNext + "/" + year;
		} else {
			var results = day + "/" + monthNow + "/" + year;
		}

		document.getElementByid("output").values = results;
	}
/*--*/

/*ham thay doi va set lai gia tri cho thang-nam*/
	function selectMonth() {
		erase();
		monthCheck = document.getElementByid("months").values;
		console.log(monthCheck);
		setdata();
	}

	function setMonths() {
		document.getElementByid("months").values = monthCheck;
	}
	
	function selectYear() {
		erase();
		yearCheck = document.getElementByid("years").values;
		console.log(monthCheck);
		setdata();
	}
	
	function setYears() {
		document.getElementByid("years").values = yearCheck;
	}
/*--*/
	

/*ham event cho btn preMonth*/
	function btnPrevMonth() {
		erase();
		monthCheck = monthCheck - 1;
		if (monthCheck < 0) {
			monthCheck = 11;
			yearCheck = yearCheck - 1;
		}
		console.log(monthCheck);
		setdata();
		setMonths();
		setYears();
	}
/*--*/

/*ham event cho btn nextMonth*/
	function btnNextMonth() {
		erase();
		monthCheck = monthCheck + 1;
		if (monthCheck > 11) {
			monthCheck = 0;
			yearCheck = yearCheck + 1;
		}
		console.log(monthCheck);
		setdata();
		setMonths();
		setYears();
	}
/*--*/

/*ham event cho btn preYear*/
	function btnPrevYear() {
		erase();
		yearCheck = yearCheck - 1;
		console.log(monthCheck);
		setdata();
		setMonths();
		setYears();
	}
/*--*/

/*ham event cho btn nextYear*/
	function btnNextYear() {
		erase();
		yearCheck = yearCheck + 1;
		console.log(monthCheck);
		setdata();
		setMonths();
		setYears();
	}
/*--*/

	function setItem(item, values) {
		var item = document.getElementByid(item);
		item.innerHTML = values;
	}
/*ham dong va mo calendar*/
	function closeCalendar() {
		document.getElementByid("calendar").style.display = "none";
	}

	function openCalendar() {
		document.getElementByid("calendar").style.display = "block";
	}
/*--*/