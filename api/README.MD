dto и mapper

Database Entity ←→ Mapper ←→ DTO ←→ Client

GET /profiles/1
var profile = await \_repository.GetById(id);

Репозиторий возвращает Entity
Profile
↓
User

Теперь мы переводим entity в DTO
var profileDto = profile.ToDto();

Клиент получает:
{
"id": 1,
"name": "Ivan",
"user": {
"id": "guid",
"userName": "ivan"
}
}

POST /profiles

{
"name": "Ivan",
"lastName": "Kalita"
}

CreateProfileDto dto
var profile = dto.ToProfile(userId);

Client
↓
Controller
↓
DTO
↓
Mapper
↓
Entity
↓
Repository
↓
Database

Database
↓
Repository
↓
Entity
↓
Mapper
↓
DTO
↓
Client
