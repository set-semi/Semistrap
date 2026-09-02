param(
    [string]$Path = "."
)

$files = Get-ChildItem -Path $Path -Recurse -Include "*.cs","*.xaml" | Where-Object { $_.FullName -notmatch "\\wpfui\\" }

foreach ($file in $files) {
    $content = Get-Content -Path $file.FullName -Raw
    
    if ($file.Extension -eq ".cs") {
        $content = $content -replace '//(?!"[^"]*")\s*.*$', ''
        $content = $content -replace '/\*[\s\S]*?\*/', ''
        $content = $content -replace '///\s*.*$', ''
        $content = $content -replace '(?m)^\s*\r?\n', ''
    }
    elseif ($file.Extension -eq ".xaml") {
        $content = $content -replace '<!--[\s\S]*?-->', ''
        $content = $content -replace '(?m)^\s*\r?\n', ''
    }
    
    Set-Content -Path $file.FullName -Value $content.Trim()
}

Write-Host "Comments removed from $($files.Count) files"
