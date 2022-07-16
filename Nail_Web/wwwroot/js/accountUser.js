
function previewImage( image, preview, string )
{

  var preview     = document.querySelector( preview );
  var fileImage   = image.files[0];
  var reader      = new FileReader();
  reader.addEventListener( "load", function() {
    preview.title           = fileImage.name;
    preview.src             = reader.result;
    document.querySelector( string ).value = reader.result;

  }, false );

  if ( fileImage )
  {
    reader.readAsDataURL( fileImage );
  }
}
document.querySelector( "#imageID" ).addEventListener( "change", function() {

  previewImage( this, "#imagePreviewID", "#imageStringID" );

} )


