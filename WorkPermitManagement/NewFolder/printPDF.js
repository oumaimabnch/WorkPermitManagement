<script>
    $("#printPDF").click(function(){
        var element=document.getElementById('parentDiv');
    html2pdf().from(element).set({
        margin:[30,10,5,10],
    pagebreak:{avoid:'tr'},
    jsPDF:{orientation:'landscape',unit:'pt',format:'letter',compressPDF:true}
    }).save()
    });

</script>
