# Historias Clinicas 📖

## Prueba del proyecto
- Descargar o clonar proyecto.
- Ejecutarlo en ISS Express.
- Presionar el botón de precarga.
- La contraseña a utilizar para todas las cuentas precargadas es "Password1".
- Emails de las cuentas precargadas:
     - mateo@ort.edu.ar (Médico).
     - camila@ort.edu.ar (Médico).
     - francisco@ort.edu.ar (Empleado).
     - paola@ort.edu.ar (Empleado).
     - valentino@ort.edu.ar (Paciente).
     - juan@ort.edu.ar (Paciente).
 
## Caracteristicas y Funcionalidades ⌨️

**Usuario**
- Los Pacientes pueden auto registrarse.
- La autoregistración desde el sitio, es exclusiva para los pacientes. Por lo cual, se le asignará dicho rol.
- Los empleados, deben ser agregados por otro Empleado. Lo mismo, para los Medicos.
- Al momento, del alta del empleado o medico, se le definirá un username y password.
- También se le asignará a estas cuentas el rol de empleado y/o medico según corresponda.

**Paciente**
- Un paciente puede consultar su historia clinica, con todos los detalles que la componen, en modo solo visualización.
- Puede acceder a los episodios, y por cada episodio, ver las evoluciones que se tienen, con sus detalles.
- Puede actualizar datos de contacto, como el telefono, dirección,etc.. Pero no puede modificar su DNI, Nombre, Apellido, etc.
- Para que un médico aparezca en la sección de "Mis Médicos", debe dirigirse a "Cartilla Médica" y solicitar un turno con el profesional deseado.

**Empleado**
- Un empleado, puede modificar todos los datos de los pacientes. 
-- No puede quitar o asociar una nueva Historia Clinica a los pacientes.
- El Empleado puede listar todos los pacientes, y por cada uno, ver en sus detalles, la HistoriaClinica que tiene asociada y si tiene episodios abiertos. 
- El Empleado, puede crear un paciente, un empleado, y un medico. Cada uno de ellos, con su correspondientes datos requeridos y usuario.
- El Empleado, puede crear un Episodio para el Paciente, en la Historia Clinica del paciente.
-- Pero no puede hacer más nada, que crearlo con su Motivo y Descripción.

**Medico**
- Un Medico, puede crear evoluciones, en Episodios que esten en estado abierto.
-- Para ello, buscará al paciente, accederá a su Historia Clinica -> Episodio -> Crear la Evolución.
- Un medico puede cerrar una evlución, si se han completado todos los campos. El campo de FechaYHoraCierre, se guardará automaticamente. 
-- Un Empleado o Medico, pueden cargar notas en cada evolución según sea necesario.
-- Las notas pueden continuar agregandose, luego del cierre de la evolución.
- Puede cerrar un Episodio, pero para hacer esto, el sistema realizará ciertas validaciones.

**HistoriaClinica**
- La misma se crea automaticamente con la creación de un paciente.
-- No se puede eliminar, ni realizar modificaciones posteriores.
-- El detalle internos de la misma, para los Medicos y empleados, pero dependiendo del rol, es lo que podrán hacer.
-- El paciente propietario de la HC, es el unico paciente que puede ver la HC.

- Por medio de la HC, se podrá acceder a la lista de Episodios, que tenga relacionados.

**Epidodio**
- La creación de un Episodio en una HC, solo puede realizarla un empleado.
-- El empleado, deberia acceder a un Paciente -> HC -> Crear Episodio, e ingresará:
--- Motivo. Ej. Traumatismo en pierna Izquierda.
--- Descripción. Ej. El paciente se encontraba andando en Skate y sufrió un accidente.
- El episodio se:
-- Creará en estadoAbierto automaticamente
-- Con una FechaYHoraInicio también, de forma automática.
-- Con un Empleado, como el que creó el episodio. (persona en recepción, que recibe al paciente).

- Solo un medico puede cerrar un Episodio, para hacer esto, el sistema, validará:
-- 1. Que el Episodio, no tenga ninguna Evlución en estado Abierta o no tenga evoluciones. Si fuese así, deberá mostrar un mensaje.
-- 2. Cargará el Medico manualmente la FechaYHoraAlta (alta del episodio) del paciente.
-- 3. Le pedirá que cargue una Epicrisis, con su diagnostico y recomendaciones.
--- Una vez finalizado el diagnostico, el Episodio, pasará a esatr en estado Cerrado.
-- 4. La FechaYHoraCierre, será cargada automaticamente, si se cumplen los requerimientos previos.

Nota: Si el cierre del episodio, es por la condición sin evoluciones, se generará un "Cierre Administrativo", en el cual, el sistema, cargará una epicrisi, con alguna información que el empleado ingresará para dejar registro de que fue un cierre administrativo. Ej. El paciente realizó el ingreso y antes de ser atendido, se fué. 

**Evolucion**
- Una evolución, solo la puede crear y gestionar un Medico.
-- La unica excepción, es que un empleado, puede cargar notas en Evoluciones por cuestiones administrativas. Ej. Salvo, que el alta del paciente en la evolución, es 10/08/2020
- Automaticamente al crear una evolución se cargará:
-- Medico que la esta creando
-- FechaYHoraInicio
-- EstadoAbierto
-- FechaYHoraCierre (Cuando se registre el cierre)
- Manualmente:
-- La FechaYHoraAlta
-- DescripcionAtencion
-- Notas (Las que sean necesarias)

- Para cerrar una evolución, se deben haber cargado todos los datos manuales requeridos, y solo lo puede hacer un Medico.

**Nota**
- La nota pertenece a una evolución. 
-- Para crearla, uno solo puede hacerla desde una Evolución.
- En las notas, puede cargar un mensaje cualquier empleado o medico.
- Quedará automaticmente la fecha y hora, como asi también, quien es el que la cargó.


**Epicrisis**
- La epicrisis, pertenes a un Episodio.
-- Solo puede haber una epicrisis por episodio.
-- Para poder crearla, todas las evoluciones, deben estar cerradas.
-- El Episodio debe estar abierto, y al finalizar este proceso, de estar todo ok, se debe cerrar automaticamente.
-- La epicrisis, solo debe poder cargarla un Medico.
-- La excepción, es la creación automatica, si cierra un empleado, por proceso administrativo.
-- La FechayHora, se carga automaticamente
-- El Diagnostico, de forma Manual.

**Diagnostico**
- Pertenece a una Epicrisis. 
- Se cargará una descripcion de forma manual
- También se cargará una recomendacion.


**Aplicación General**
- Información institucional.
- Se deben listar el cuerpo medico, junto con sus especialidades.
- Los accesos a las funcionalidades y/o capacidades, debe estar basada en los roles que tenga cada individuo.
