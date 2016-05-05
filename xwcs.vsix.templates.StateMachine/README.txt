Come rigeneare il VSIX per le State Machine.

- Modificare opportunamente il file Model.Machine.tt. In esso sono presenti in testa ed in coda alcuni placeholder che devono rimanere invariati
- Fare 'Build' del progetto xwcs.vsix.templates
- Se già presente, disinsallare il VSIX:
  - Menù 'Tools' => 'Extensions and Updates...'
  - Identificare 'xwcs.vsix.templates' e disinstallarlo
  - Chiudere il dialogo ed il Visual Studio (non vale la pena fare 'Restart')
- Installare il nuovo VSIX
  - Posizionarsi su disco nella cartella del progetto ove è stato compilato il VSIX
  - Eseguire xwcs.vsix.templates.vsix e compierne l'installazione
- Riavviare Visual Studio