var versions = ["AccountPad1.0.0.5", "AccountPad1.0.0.6","AccountPad1.0.0.7","AccountPad1.0.0.8","AccountPad1.0.1.1","AccountPad1.0.1.2"
,"AccountPad1.0.1.3","AccountPad1.0.1.5","AccountPad1.0.1.8","AccountPad1.0.2.2","AccountPad1.0.2.5"];
function ShowVersions() {
    document.write('<!DOCTYPE html><html><head><link rel="stylesheet" type="text/css" media="screen" href="main.css" /></head><body>');
    versions.forEach(element => {
        document.writeln("<a class='item' style='display:block' href='../AccountPad/InstallationPackages/" + element + ".rar'>点击下载：" + element + "</a>")
    });
    document.writeln('</body></html>');
}