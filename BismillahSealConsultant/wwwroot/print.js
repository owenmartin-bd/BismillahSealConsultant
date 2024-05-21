function PrintElem() {
    var mywindow = window.open('', 'PRINT', 'height=400,width=600');

    mywindow.document.write('<html><head><title>' + document.title + '</title>');

    mywindow.document.write('<link rel="stylesheet" href="css/bootstrap/bootstrap.min.css" />');

    mywindow.document.write('</head><body >');
   
    mywindow.document.write(document.getElementById("print").innerHTML);
    mywindow.document.write('</body></html>');

    mywindow.print();
    mywindow.close();

    return true;
}