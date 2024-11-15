# Proyecto de Gestión de Citas para Clínica

Este proyecto es una aplicación para la gestión de citas médicas en una clínica privada. Permite la administración de citas, la visualización de disponibilidad de médicos, la programación de nuevas citas, y el seguimiento del historial médico de los pacientes.

## Variables de Entorno

Para configurar y ejecutar correctamente este proyecto, es necesario definir las siguientes variables de entorno. Puedes hacerlo creando un archivo `.env` en la raíz del proyecto o configurando directamente en tu entorno de ejecución.

### Variables de Entorno

```env
DB_HOST=bn0tcy1ueqglphdosucd-mysql.services.clever-cloud.com
DB_PORT=3306
DB_DATABASE=bn0tcy1ueqglphdosucd
DB_USERNAME=uv4noz9jyusx9w5s
DB_PASSWORD=F9875UH7afDZngLkSqtM

JWT_KEY=79gK6ueP6g35cAUV20OgpsnGwrKQt7ayhWi
JWT_ISSUER=http://localhost:5140
JWT_AUDIENCE=public
JWT_EXPIREMINUTES=60
